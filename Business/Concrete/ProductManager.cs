using Business.Abstract;
using Core.DTOs.Category;
using Core.DTOs.Product;
using DataAccess.Abstract;
using DataAccess.Concrete.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(CreateProductDto dto)
        {
            try
            {
                _productDal.Add(dto);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Delete(int id)
        {
            try
            {
                _productDal.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Task<List<ResultProductDto>> GetAll()
        {
            try
            {
                return _productDal.GetAll();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Task<ResultProductDto> GetById(int id)
        {
            try
            {
                return _productDal.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(UpdateProductDto dto)
        {
            try
            {
                _productDal.Update(dto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
