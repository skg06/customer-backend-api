using System.Collections.Generic;

namespace Customers.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IList<T> List();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
