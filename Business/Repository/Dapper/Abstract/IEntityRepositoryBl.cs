using Core.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.Dapper.Abstract
{
    public interface IEntityRepositoryBl<T> where T : class,new()
    {
        Task<List<T>> GetAll();
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        Task<T> GetById(int id);
    }
}
