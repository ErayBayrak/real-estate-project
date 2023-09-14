using Core.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        Task<List<ResultProductDto>> GetAll();
        void Add(CreateProductDto categoryDto);
        void Delete(int id);
        void Update(UpdateProductDto categoryDto);
        Task<ResultProductDto> GetById(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllWithCategory();
    }
}
