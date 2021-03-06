﻿using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GridBlazor.Demo.Server.Models
{
    public abstract class SqlRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> EfDbSet;

        protected SqlRepository(DbContext context)
        {
            EfDbSet = context.Set<T>();
        }

        #region IRepository<T> Members

        public virtual IQueryable<T> GetAll()
        {
            return EfDbSet;
        }

        public abstract T GetById(object id);

        #endregion
    }
}