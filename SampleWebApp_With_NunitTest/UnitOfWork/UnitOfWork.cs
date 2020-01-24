using SampleWebApp_With_NunitTest.Models;
using SampleWebApp_With_NunitTest.Repositories;

namespace SampleWebApp_With_NunitTest.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<User> _UserRepository;

        public IRepository<User> UserRepository
        {
            get
            {
                if (_UserRepository == null)
                    _UserRepository = new Repository<User>();

                return _UserRepository;
            }
        }
    }
}
