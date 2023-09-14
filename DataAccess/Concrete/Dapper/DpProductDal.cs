using Core.DTOs.Product;
using Dapper;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpProductDal:IProductDal
    {
        private readonly Context _context;
        public DpProductDal(Context context)
        {
            _context = context;
        }

        public async void Add(CreateProductDto productDto)
        {
            string query = "insert into Category (Name,Status) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", productDto.Name);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void Delete(int id)
        {
            var removedValue = await GetById(id);
            if (removedValue != null)
            {
                string query = "Delete from Category where Id=@categoryId";
                var parameters = new DynamicParameters();
                parameters.Add("@categoryId", id);
                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters);
                }
            }
            else
            {
                throw new Exception("Değer bulunamadı.");
            }
        }

        public async Task<List<ResultProductDto>> GetAll()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllWithCategory()
        {
            string query = "Select Id,Title,Price,City,District,Category.Name From Product inner join Category on Product.Id=Category.Id";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultProductDto> GetById(int id)
        {
            string query = "Select * From Category Where Id=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultProductDto>(query, parameters);
                return value;
            }
        }

        public async void Update(UpdateProductDto categoryDto)
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
