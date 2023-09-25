using Core.DTOs.Service;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpServiceDal : IServiceDal
    {
        private readonly Context _context;
        public DpServiceDal(Context context)
        {
            _context = context;
        }
        public void Add(CreateServiceDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultServiceDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ResultServiceDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateServiceDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
