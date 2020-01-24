using SampleWebApp_With_NunitTest.Models;
using SampleWebApp_With_NunitTest.Repositories;

namespace SampleWebApp_With_NunitTest.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }
    }
}
