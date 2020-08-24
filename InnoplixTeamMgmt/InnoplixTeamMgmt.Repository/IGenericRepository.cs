using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InnoplixTeamMgmt.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);

        Task<T> GetByIdAsync(int id);

        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();


        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);

        // IQueryable<T> Query(string sql, params object[] parameters);

        //T Search(params object[] keyValues);

        //T Single(Expression<Func<T, bool>> predicate = null,
        //Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        //bool disableTracking = true);


        void Add(T entity);

        void AddAsync(T entity);

        void AddRange(IEnumerable<T> entities);
        //void Add(params T[] entities);
        //void Add(IEnumerable<T> entities);

        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        //void Delete(object id);
        //void Delete(params T[] entities);
        //void Delete(IEnumerable<T> entities);

        void Update(T entity);
        //void Update(params T[] entities);
        //void Update(IEnumerable<T> entities);
    }
}
