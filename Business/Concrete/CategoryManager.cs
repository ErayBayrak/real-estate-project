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

        public Task<List<ResultCategoryDto>> GetAllCategories()
        {
            return _categoryDal.GetAllCategories();
        }
    }
}
