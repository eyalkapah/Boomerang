using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Contracts.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);

        void AddRange(IEnumerable<TEntity> entities);

        bool Any(Expression<Func<TEntity, bool>> predicate);

        bool Delete(object[] keyValues);

        void Delete(TEntity item);

        bool Delete<TKey>(TKey key);

        TEntity Find(params object[] keyValues);

        bool IsEmpty();

        bool IsExists(object[] keyValues);

        bool IsExists<TKey>(TKey keyValue);

        IQueryable<TEntity> Queryable();

        IQueryable<TEntity> QueryableSql(string sql, params object[] parameters);

        void Update(TEntity item);
    }
}