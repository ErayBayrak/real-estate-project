using Business.Abstract;
using Core.DTOs.Testimonial;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Task<List<ResultTestimonialDto>> GetAll()
        {
            try
            {
                var values = _testimonialDal.GetAll();
                return values;
            }
            catch (Exception)
            {

                throw;
            }
             
        }
    }
}
