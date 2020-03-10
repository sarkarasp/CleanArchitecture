using OA.DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repository.Layer
{
   public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);

        void SaveChanges();
    }
}
