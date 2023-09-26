using Core.DTOs.BottomGrid;
using Core.DTOs.PopularLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPopularLocationService
    {
        Task<List<ResultPopularLocationDto>> GetAll();
        void Add(CreatePopularLocationDto dto);
        void Delete(int id);
        void Update(UpdatePopularLocationDto dto);
        Task<ResultPopularLocationDto> GetById(int id);
    }
}
