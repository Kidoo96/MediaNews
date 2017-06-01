using MediaNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MediaNews.Repositories
{
    public class BaseRepository<T> where T:BaseModel, new()
    {
        private ApplicationDbContext context;
        private DbSet<T> dbSet;


        public BaseRepository()
        {
            this.context = new ApplicationDbContext();
            this.dbSet = this.context.Set<T>();
        }

        //public BaseRepository(UnitOfWork unitOfWork)
        //{
        //    this.context = new ApplicationDbContext();
        //    this.dbSet = this.context.Set<T>();
        //}

        public void Insert(T item)
        {
            this.dbSet.Add(item);
            this.context.SaveChanges();
        }

        public void Update(T item)
        {
            this.context.Entry(item).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            this.dbSet.Remove(this.dbSet.Find(id));
            this.context.SaveChanges();
        }

        public void GetById(int id)
        {
            this.dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbSet;
        }
    }
}