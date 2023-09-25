using Core.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IServiceDal
    {
        Task<List<ResultCategoryDto>> GetAll();
        void Add(CreateCategoryDto categoryDto);
        void Delete(int id);
        void Update(UpdateCategoryDto categoryDto);
        Task<ResultCategoryDto> GetById(int id);
    }
}
