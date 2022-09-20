using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.Persistence.Repositories
{
    public interface IReadRepository<T> where T : Entity
    {
        Task<IPaginate<T>> GetListAsync (Expression<Func<T, bool>>? predicate = null, 
                                         Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, 
                                         Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, 
                                         int index = 0, int size = 10, bool tracking = true, 
                                         CancellationToken cancellationToken = default);

        Task<IPaginate<T>> GetListByDynamicAsync (Dynamic.Dynamic dynamic,
                                                  Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                                  int index = 0, int size = 10, bool tracking = true,
                                                  CancellationToken cancellationToken = default);

        Task<T> GetAsync (Expression<Func<T, bool>> predicate, 
                          Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, 
                          bool tracking = true);
        Task<T> GetByIdAsync (string id, bool tracking = true);
    }
}
