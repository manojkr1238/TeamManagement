using InnoplixTeamMgmt.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnoplixTeamMgmt.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DynamixTeamDbContext _context { get; }

        public UnitOfWork(DynamixTeamDbContext dbContext)
        {
           this._context = dbContext;
        }

        public GenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
