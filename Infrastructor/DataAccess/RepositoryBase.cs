using Infrastructor.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructor.DataAccess
{
    public class RepositoryBase<TEntity, TContext>
                where TEntity : BaseEntity, new()
                where TContext : DbContext, new()
    {
        public List<TEntity> GetAll()
        {
            TContext ctx = new TContext();
            return ctx.Set<TEntity>().ToList();
        }

    }
}
