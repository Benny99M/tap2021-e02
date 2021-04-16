using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ADIBAS.DataAccess
{
    interface IDataRepository
    {
        IQueryable<TEntity> Query<TEntity>() where TEntity : class;

        void Delete<TEntity>(TEntity entity) where TEntity : class;

        void Update<TEntity>(TEntity entity) where TEntity : class;

        TEntity Insert<TEntity>(TEntity entity) where TEntity : class;
    }
}
