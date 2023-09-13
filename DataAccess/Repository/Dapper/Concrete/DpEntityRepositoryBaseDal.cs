using Core.DTOs.Category;
using Dapper;
using DataAccess.Concrete.Dapper;
using DataAccess.Repository.Dapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Dapper.Concrete
{
    public class DpEntityRepositoryBaseDal<TEntity> : IEntityRepositoryDal<TEntity>
        where TEntity : class, new()
    {
        private readonly Context _context;
        public DpEntityRepositoryBaseDal(Context context)
        {
            _context = context;
        }

        public async void Add(TEntity entity)
        {
            string tableName = typeof(TEntity).Name; 
            string columnNames = string.Join(", ", typeof(TEntity).GetProperties().Select(p => p.Name));
            string valueNames = string.Join(", ", typeof(TEntity).GetProperties().Select(p => $"@{p.Name}"));
            string query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({valueNames})"; 

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, entity);
            }
        }

        public async void Delete(int id)
        {
            string tableName = typeof(TEntity).Name;
            string query = $"DELETE FROM {tableName} WHERE Id = @id";

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, new { id });
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            string tableName = typeof(TEntity).Name;
            string query = $"Select * From {tableName}";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<TEntity>(query);
                return values.ToList();
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            string tableName = typeof(TEntity).Name; 
            string query = $"SELECT * FROM {tableName} WHERE Id=@id";

            using (var connection = _context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("id", id);

                var value = await connection.QueryFirstOrDefaultAsync<TEntity>(query, parameters);
                return value;
            }
        }

        public async void Update(TEntity entity)
        {
            string tableName = typeof(TEntity).Name;
            var properties = typeof(TEntity).GetProperties();
            var updateColumns = properties.Where(p => p.Name != "Id").Select(p => $"{p.Name} = @{p.Name}");
            string query = $"UPDATE {tableName} SET {string.Join(", ", updateColumns)} WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, entity);
            }
        }
    }
}
