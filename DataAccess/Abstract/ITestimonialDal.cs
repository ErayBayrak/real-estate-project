using Core.DTOs.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITestimonialDal
    {
        Task<List<ResultTestimonialDto>> GetAll();
    }
}
