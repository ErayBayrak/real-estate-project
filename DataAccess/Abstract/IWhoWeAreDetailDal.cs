﻿using Core.DTOs.Category;
using Core.DTOs.WhoWeAreDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IWhoWeAreDetailDal
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAll();
        void Add(CreateWhoWeAreDetailDto dto);
        void Delete(int id);
        void Update(UpdateWhoWeAreDetailDto dto);
        Task<ResultWhoWeAreDetailDto> GetById(int id);
    }
}
