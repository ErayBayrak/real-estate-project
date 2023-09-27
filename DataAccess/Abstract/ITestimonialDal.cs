﻿using Core.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITestimonialDal
    {
        Task<List<ResultCategoryDto>> GetAll();
    }
}
