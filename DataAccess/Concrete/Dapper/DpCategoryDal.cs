using Core.DTOs.Category;
using Dapper;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpCategoryDal : ICategoryDal
    {
        private readonly Context _context;
        public DpCategoryDal(Context context)
        {
            _context = context;
        }

        public async void AddCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (Name,Status) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName",categoryDto.Name);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategories()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query); 
                return values.ToList();
            }
        }
        
    }
}
