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

        public void AddCategory(CreateCategoryDto categoryDto)
        {
            try
            {
                _categoryDal.AddCategory(categoryDto);
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
                _categoryDal.DeleteCategory(id);
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
                return _categoryDal.GetAllCategories();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void UpdateCategory(UpdateCategoryDto categoryDto)
        {
            try
            {
                _categoryDal.UpdateCategory(categoryDto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
