using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IdealWay.Application
{
    public interface IDevSalaryDbContext
    {
        IQueryable<T> GetAllQuery<T>() where T : class;
        IQueryable<T> GetAllNoCachingQuery<T>() where T : class;       
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void AddEntity<T>(T entity) where T : class;
    }
}
