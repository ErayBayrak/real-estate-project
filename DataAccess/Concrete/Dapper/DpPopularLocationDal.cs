using Core.DTOs.PopularLocation;
using Dapper;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DataAccess.Concrete.Dapper
{
    public class DpPopularLocationDal : IPopularLocationDal
    {
        private readonly Context _context;
        public DpPopularLocationDal(Context context)
        {
            _context = context;
        }
        public async void Add(CreatePopularLocationDto dto)
        {
            string query = "insert into PopularLocation (CityName,ImageUrl) values (@cityName,@imageUrl)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@cityName", dto.CityName);
            parameters.Add("@imageUrl", dto.ImageUrl);
            using (IDbConnection connection = _context.CreateConnection())
            {
               await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void Delete(int id)
        {
            string query = "delete from PopularLocation where Id=@id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (IDbConnection connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultPopularLocationDto>> GetAll()
        {
            string query = "select * from PopularLocation";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList(); 
            }
        }

        public async Task<ResultPopularLocationDto> GetById(int id)
        {
            string query = "select * from PopularLocation where Id=@id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (IDbConnection connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultPopularLocationDto>(query, parameters);
                return value;
            }
        }

        public async void Update(UpdatePopularLocationDto dto)
        {
            string query = "update PopularLocation set CityName=@cityName,ImageUrl=@imageUrl where Id=@id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CityName", dto.CityName);
            parameters.Add("@imageUrl", dto.ImageUrl);
            parameters.Add("@id", dto.Id);
            using (IDbConnection connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
