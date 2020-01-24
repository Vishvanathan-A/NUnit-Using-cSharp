using System.Collections.Generic;

namespace SampleWebApp_With_NunitTest.Repositories
{
    public interface IRepository<T>
    {
        T Get(T entity);

        IEnumerable<T> GetAll();

        void Insert(T entity);
    }
}
