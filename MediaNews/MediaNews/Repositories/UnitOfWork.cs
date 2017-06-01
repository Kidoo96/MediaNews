using MediaNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MediaNews.Repositories
{
    public class UnitOfWork : IDisposable
    {

        private ApplicationDbContext context;
        private DbContextTransaction transaction = null;

        public UnitOfWork()
        {
            this.context = new ApplicationDbContext();
            this.transaction = this.context.Database.BeginTransaction();
        }

        public void Commit()
        {
            this.transaction.Commit();
            this.transaction = null;
        }

        public void Rollback()
        {
            this.transaction.Rollback();
            this.transaction = null;
        }

        public void Dispose()
        {
            Commit();
            this.transaction.Dispose();
        }


    }
}