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
            string query = "insert into Product (Title,Price,City,District,CategoryId) values (@title,@price,@city,@district,@categoryId)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", productDto.Title);
            parameters.Add("@price", productDto.Price);
            parameters.Add("@city", productDto.City);
            parameters.Add("@district", productDto.District);
            parameters.Add("@categoryId", productDto.CategoryId);
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
                string query = "Delete from Product where Id=@id";
                var parameters = new DynamicParameters();
                parameters.Add("@id", id);
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
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllWithCategory()
        {
            string query = "Select Product.Id,Title,Price,City,District,Name,Type,Address,CoverImage From Product inner join Category on Product.CategoryId=Category.Id";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultProductDto> GetById(int id)
        {
            string query = "Select * From Product Where Id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("id", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultProductDto>(query, parameters);
                return value;
            }
        }

        public async void Update(UpdateProductDto dto)
        {
            string query = "Update Product Set Title=@title,Price=@price,City=@city,District=@district,CategoryId=@categoryId Where Id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@title", dto.Title);
            parameters.Add("@price", dto.Price);
            parameters.Add("@city", dto.City);
            parameters.Add("@district", dto.District);
            parameters.Add("@categoryId", dto.CategoryId);
            parameters.Add("@id", dto.Id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
