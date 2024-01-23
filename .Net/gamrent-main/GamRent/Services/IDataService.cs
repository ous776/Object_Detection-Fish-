using System.Linq.Expressions;

namespace GamRent.Services
{
    public interface IDataService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> Create(T entity);
        Task<bool> Delete(T entity);
        Task<T> Update(T entity);
        Task<IEnumerable<T>> SearchFor(Expression<Func<T, bool>> expression);
        Task<T> SearchForAnEntity(Expression<Func<T, bool>> expression);
    }
}
