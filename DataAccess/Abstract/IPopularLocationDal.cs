using Core.DTOs.PopularLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPopularLocationDal
    {
        Task<List<ResultPopularLocationDto>> GetAll();
        Task<ResultPopularLocationDto> GetById(int id);
        void Add(CreatePopularLocationDto dto);
        void Update(UpdatePopularLocationDto dto);
        void Delete(int id);
    }
}
