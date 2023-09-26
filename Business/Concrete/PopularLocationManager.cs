using Business.Abstract;
using Core.DTOs.PopularLocation;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PopularLocationManager : IPopularLocationService
    {
        IPopularLocationDal _popularLocationDal;

        public PopularLocationManager(IPopularLocationDal popularLocationDal)
        {
            _popularLocationDal = popularLocationDal;
        }

        public void Add(CreatePopularLocationDto dto)
        {
            try
            {
                _popularLocationDal.Add(dto);
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
                _popularLocationDal.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<List<ResultPopularLocationDto>> GetAll()
        {
            try
            {
                return _popularLocationDal.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<ResultPopularLocationDto> GetById(int id)
        {
            try
            {
                return _popularLocationDal.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(UpdatePopularLocationDto dto)
        {
            try
            {
                _popularLocationDal.Update(dto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
