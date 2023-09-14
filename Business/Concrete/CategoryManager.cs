using Business.Abstract;
using Business.Repository.Dapper.Concrete;
using Core.DTOs.Category;
using DataAccess.Abstract;
using DataAccess.Repository.Dapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(CreateCategoryDto categoryDto)
        {
            try
            {
                _categoryDal.Add(categoryDto);
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
                _categoryDal.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Task<List<ResultCategoryDto>> GetAll()
        {
            try
            {
                return _categoryDal.GetAll();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Task<ResultCategoryDto> GetById(int id)
        {
            try
            {
                return _categoryDal.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(UpdateCategoryDto categoryDto)
        {
            try
            {
                _categoryDal.Update(categoryDto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
