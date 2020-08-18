using InnoplixTeamMgmt.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnoplixTeamMgmt.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        int Commit();
    }

    public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : DynamixTeamDbContext
    {
        TContext Context { get; }
    }
}
