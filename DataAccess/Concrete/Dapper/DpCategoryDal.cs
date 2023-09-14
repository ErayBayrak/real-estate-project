using Core.DTOs.Category;
using Dapper;
using DataAccess.Abstract;
using DataAccess.Repository.Dapper.Concrete;
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

        public async void Add(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (Name,Status) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.Name);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void Delete(int id)
        {
            string query = "Delete from Category where Id=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAll()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultCategoryDto> GetById(int id)
        {
            string query = "Select * From Category Where Id=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultCategoryDto>(query, parameters);
                return value;
            }
        }

        public async void Update(UpdateCategoryDto categoryDto)
        {
            string query = "Update Category Set Name=@categoryName,Status=@categoryStatus Where Id=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.Name);
            parameters.Add("@categoryStatus", categoryDto.Status);
            parameters.Add("@categoryId", categoryDto.Id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
