using Core.DTOs.Testimonial;
using Dapper;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpTestimonialDal : ITestimonialDal
    {
        private readonly Context _context;
        public DpTestimonialDal(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultTestimonialDto>> GetAll()
        {
            string query = "select * from Testimonial";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }
    }
}
