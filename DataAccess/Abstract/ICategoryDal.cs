﻿using Core.DTOs.Category;
using DataAccess.Repository.Dapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepositoryDal<ResultCategoryDto>
    {
        
    }
}
