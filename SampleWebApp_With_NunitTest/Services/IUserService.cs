using SampleWebApp_With_NunitTest.Models;
using System.Collections.Generic;

namespace SampleWebApp_With_NunitTest.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();

        User GetById(int id);

        User Insert(User user);
    }
}
