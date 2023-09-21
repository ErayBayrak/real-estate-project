using Business.Abstract;
using Core.DTOs.WhoWeAreDetail;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WhoWeAreDetailManager : IWhoWeAreDetailService
    {
        IWhoWeAreDetailDal _whoWeAreDetailDal;

        public WhoWeAreDetailManager(IWhoWeAreDetailDal whoWeAreDetailDal)
        {
            _whoWeAreDetailDal = whoWeAreDetailDal;
        }

        public void Add(CreateWhoWeAreDetailDto dto)
        {
            try
            {
                _whoWeAreDetailDal.Add(dto);
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
                _whoWeAreDetailDal.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Task<List<ResultWhoWeAreDetailDto>> GetAll()
        {
            try
            {
                return _whoWeAreDetailDal.GetAll();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Task<ResultWhoWeAreDetailDto> GetById(int id)
        {
            try
            {
                return _whoWeAreDetailDal.GetById(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Update(UpdateWhoWeAreDetailDto dto)
        {
            try
            {
                _whoWeAreDetailDal.Update(dto);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
