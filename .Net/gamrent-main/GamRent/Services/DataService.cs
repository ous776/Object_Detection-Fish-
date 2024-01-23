using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GamRent.Services
{
    public class DataService<T> : IDataService<T> where T : class
    {
        private readonly CrudContextFactory _contextFactory;
        public DataService(CrudContextFactory contextFactory) { _contextFactory = contextFactory; }
        public async Task<T> Create(T entity)
        {
            try
            {
                using (AssetDbContext context = _contextFactory.CreateDbContext())
                {

                    EntityEntry<T> createdResult = context.Set<T>().Add(entity);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        try
                        {
                            createdResult = await context.Set<T>().AddAsync(entity);
                            await context.SaveChangesAsync();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }

                    return createdResult.Entity;
                };
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                using (AssetDbContext context = _contextFactory.CreateDbContext())
                {
                    context.Set<T>().Remove(entity);
                    await context.SaveChangesAsync();
                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> GetById(Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                {
                    return null;
                }

                AssetDbContext context = _contextFactory.CreateDbContext();
                var result = await context.Set<T>().FindAsync(id);
                return result;


            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {

                AssetDbContext context = _contextFactory.CreateDbContext();
                var result = context.Set<T>().ToArray();
                return result;


            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<IEnumerable<T>> SearchFor(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            try
            {

                AssetDbContext context = _contextFactory.CreateDbContext();
                var result = context.Set<T>().Where(expression).ToList();
                return result;

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<T> SearchForAnEntity(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            try
            {
                AssetDbContext context = _contextFactory.CreateDbContext();
                var result = context.Set<T>().Where(expression).ToList();
                return (result != null && result.Count > 0) ? result.FirstOrDefault() : null;



            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public async Task<T> SearchForAnEntityById(Guid id)
        {
            try
            {
                AssetDbContext context = _contextFactory.CreateDbContext();
                var result = context.Set<T>().Find(id);
                return result;

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public async Task<T> Update(T entity)
        {
            try
            {
                AssetDbContext context = _contextFactory.CreateDbContext();
                //using ()
                //{ }
                EntityEntry<T> createdResult = context.Set<T>().Update(entity);
                try
                {
                    context.SaveChanges();
                    return entity;
                }
                catch (Exception ex)
                {

                    string str = ex.Message;
                    context.Set<T>().Update(entity);
                    await context.SaveChangesAsync();
                    return entity;
                    //throw ex;
                }



            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
