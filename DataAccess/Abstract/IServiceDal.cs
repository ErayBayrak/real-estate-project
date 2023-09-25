using Core.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IServiceDal
    {
        Task<List<ResultServiceDto>> GetAll();
        void Add(CreateServiceDto dto);
        void Delete(int id);
        void Update(UpdateServiceDto dto);
        Task<ResultServiceDto> GetById(int id);
    }
}
