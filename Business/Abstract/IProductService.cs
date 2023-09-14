using Core.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAll();
        void Add(CreateProductDto dto);
        void Delete(int id);
        void Update(UpdateProductDto dto);
        Task<ResultProductDto> GetById(int id);
    }
}
