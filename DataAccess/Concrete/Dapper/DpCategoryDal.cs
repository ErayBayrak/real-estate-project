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
    public class DpCategoryDal : DpEntityRepositoryBaseDal<ResultCategoryDto>, ICategoryDal
    {
        public DpCategoryDal(Context context) : base(context)
        {
        }
    }
}
