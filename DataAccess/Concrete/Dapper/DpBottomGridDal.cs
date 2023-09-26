using Core.DTOs.BottomGrid;
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
    public class DpBottomGridDal : IBottomGridDal
    {
        private readonly Context _context;
        public DpBottomGridDal(Context context)
        {
            _context = context;
        }
        public async void Add(CreateBottomGridDto dto)
        {
            string query = "Insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@icon", dto.Icon);
            parameters.Add("@title", dto.Title);
            parameters.Add("@description", dto.Description);
            using (IDbConnection connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void Delete(int id)
        {
            var removedValue = await GetById(id);
            if (removedValue !=null)
            {
                string query = "delete from BottomGrid where Id=@id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@id", id);
                using (IDbConnection connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters);
                }
            }
        }

        public async Task<List<ResultBottomGridDto>> GetAll()
        {
            string query = "select * from BottomGrid";
            using (IDbConnection connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList(); 
            }
        }

        public async Task<ResultBottomGridDto> GetById(int id)
        {
            string query = "select * from BottomGrid where Id=@id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (IDbConnection connection = _context.CreateConnection())
            {
              var value = await connection.QueryFirstOrDefaultAsync<ResultBottomGridDto>(query, parameters);
              return value;
            }
        }

        public async void Update(UpdateBottomGridDto dto)
        {
            string query = "Update BottomGrid Set Icon=@icon,Title=@title,Description=@description where Id=@id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@icon",dto.Icon);
            parameters.Add("@title",dto.Title);
            parameters.Add("@description",dto.Description);
            parameters.Add("@id",dto.Id);
            using (IDbConnection connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
