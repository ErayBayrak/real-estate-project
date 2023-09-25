using Core.DTOs.Service;
using Dapper;
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
        public async void Add(CreateServiceDto dto)
        {
            string query = "insert into Service (Name,Status) values (@name,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", dto.Name);
            parameters.Add("@status", dto.Status);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async void Delete(int id)
        {
            var removedValue = await GetById(id);
            if (removedValue != null)
            {
                string query = "delete from Service where Id=@serviceId";
                var parameters = new DynamicParameters();
                parameters.Add("@serviceId", id);
                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters);
                }
            } 
        }

        public async Task<List<ResultServiceDto>> GetAll()
        {
            string query = "select * from Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultServiceDto> GetById(int id)
        {
            string query = "select * from Service where Id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultServiceDto>(query);
                return value;
            }
        }

        public async void Update(UpdateServiceDto dto)
        {
            string query = "update Service set Name=@name,Status=@status where Id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@name", dto.Name);
            parameters.Add("@status", dto.Status);
            parameters.Add("@id", dto.Id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
