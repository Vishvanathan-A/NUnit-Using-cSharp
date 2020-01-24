using SampleWebApp_With_NunitTest.Models;
using SampleWebApp_With_NunitTest.UnitOfWork;
using System.Collections.Generic;

namespace SampleWebApp_With_NunitTest.Services
{
    public class UserService : IUserService
    {
        #region Constructor
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Implementations

        public IEnumerable<User> GetAllUsers()
        {
            var users = _unitOfWork.UserRepository.GetAll();

            return users;
        }

        public User GetById(int id)
        {
            var users = _unitOfWork.UserRepository.Get(new User { Id = id });

            return users;
        }

        public User Insert(User user)
        {
            _unitOfWork.UserRepository.Insert(user);

            return user;
        }

        #endregion
    }
}
