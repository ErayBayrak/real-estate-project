using Business.Abstract;
using Core.DTOs.Category;
using DataAccess.Abstract;
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

        public void AddCategory(ResultCategoryDto categoryDto)
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

        public void DeleteCategory(int id)
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

        public Task<List<ResultCategoryDto>> GetAllCategories()
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

        public void UpdateCategory(ResultCategoryDto categoryDto)
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
