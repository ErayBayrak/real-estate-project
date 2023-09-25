using Business.Abstract;
using Core.DTOs.Service;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(CreateServiceDto dto)
        {
            try
            {
                _serviceDal.Add(dto);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                _serviceDal.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Task<List<ResultServiceDto>> GetAll()
        {
            try
            {
               return _serviceDal.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<ResultServiceDto> GetById(int id)
        {
            try
            {
                return _serviceDal.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(UpdateServiceDto dto)
        {
            try
            {
                _serviceDal.Update(dto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
