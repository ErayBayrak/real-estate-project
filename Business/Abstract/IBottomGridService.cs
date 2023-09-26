using Core.DTOs.BottomGrid;
using Core.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBottomGridService
    {
        Task<List<ResultBottomGridDto>> GetAll();
        void Add(CreateBottomGridDto dto);
        void Delete(int id);
        void Update(UpdateBottomGridDto dto);
        Task<ResultBottomGridDto> GetById(int id);
    }
}
