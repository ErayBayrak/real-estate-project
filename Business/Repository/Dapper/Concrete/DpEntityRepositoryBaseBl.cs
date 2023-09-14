using Business.Repository.Dapper.Abstract;
using DataAccess.Repository.Dapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.Dapper.Concrete
{
    public class DpEntityRepositoryBaseBl<TEntity> : IEntityRepositoryBl<TEntity>
        where TEntity : class,new()
    {
        private readonly IEntityRepositoryDal<TEntity> _entityRepositoryDal;

        public DpEntityRepositoryBaseBl(IEntityRepositoryDal<TEntity> entityRepositoryDal)
        {
            _entityRepositoryDal = entityRepositoryDal;
        }

        public void Add(TEntity entity)
        {
            _entityRepositoryDal.Add(entity);
        }

        public void Delete(int id)
        {
            _entityRepositoryDal.Delete(id);
        }

        public Task<List<TEntity>> GetAll()
        {
            return _entityRepositoryDal.GetAll();
        }

        public Task<TEntity> GetById(int id)
        {
            return _entityRepositoryDal.GetById(id);    
        }

        public void Update(TEntity entity)
        {
            _entityRepositoryDal.Update(entity);
        }
    }
}
