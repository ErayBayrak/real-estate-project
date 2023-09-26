using Business.Abstract;
using Core.DTOs.BottomGrid;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BottomGridManager : IBottomGridService
    {
        IBottomGridDal _bottomGridDal;

        public BottomGridManager(IBottomGridDal bottomGridDal)
        {
            _bottomGridDal = bottomGridDal;
        }

        public void Add(CreateBottomGridDto dto)
        {
            try
            {
                _bottomGridDal.Add(dto);
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
                _bottomGridDal.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<List<ResultBottomGridDto>> GetAll()
        {
            try
            {
                return _bottomGridDal.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<ResultBottomGridDto> GetById(int id)
        {
            try
            {
               return _bottomGridDal.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(UpdateBottomGridDto dto)
        {
            try
            {
                _bottomGridDal.Update(dto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
