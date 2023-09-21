using Core.DTOs.Category;
using Core.DTOs.WhoWeAreDetail;
using Dapper;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DpWhoWeAreDetailDal : IWhoWeAreDetailDal
    {
        private readonly Context _context;
        public DpWhoWeAreDetailDal(Context context)
        {
            _context = context;
        }
        public async void Add(CreateWhoWeAreDetailDto dto)
        {
            string query = "insert into WhoWeAreDetail (Title,Subtitle,Description1,Description2) values (@title,@subtitle,@description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", dto.Title);
            parameters.Add("@subtitle", dto.Subtitle);
            parameters.Add("@description1", dto.Description1);
            parameters.Add("@description2", dto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void Delete(int id)
        {
            var removedValue = await GetById(id);
            if (removedValue != null)
            {
                string query = "Delete from WhoWeAreDetail where Id=@id";
                var parameters = new DynamicParameters();
                parameters.Add("@id", id);
                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters);
                }
            }
            else
            {
                throw new Exception("Değer bulunamadı.");
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAll()
        {
            string query = "Select * From WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultWhoWeAreDetailDto> GetById(int id)
        {
            string query = "Select * From WhoWeAreDetail Where Id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("id", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultWhoWeAreDetailDto>(query, parameters);
                return value;
            }
        }

        public async void Update(UpdateWhoWeAreDetailDto dto)
        {
            string query = "Update WhoWeAreDetail Set Title=@title,Subtitle=@subtitle,Description1=@description1,Description2=@description2 Where Id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@title", dto.Title);
            parameters.Add("@subtitle", dto.Subtitle);
            parameters.Add("@description1", dto.Description1);
            parameters.Add("@description2", dto.Description2);
            parameters.Add("@id", dto.Id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
