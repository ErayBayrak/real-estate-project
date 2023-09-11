using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dapper.Abstract
{
    public interface IEntityRepository<T> where T: class,new()
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T,bool>> result=null);
        Task<T> Get(Expression<Func<T, bool>> result);
        Task Create(T company);
        Task Update(int id, T company);
        Task Delete(int id);
    }
}
