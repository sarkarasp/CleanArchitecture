using Microsoft.EntityFrameworkCore;
using OA.DomainEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA.Repository.Layer
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entitites;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entitites = context.Set<T>();
        }
        
        public T Get(long id)
        {
            return entitites.SingleOrDefault(t => t.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entitites.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            entitites.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            entitites.Remove(entity);
            context.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            entitites.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

       
    }
}
