
using SampleWebApp_With_NunitTest.Models;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTest
{
    public class SampleData
    {
        public static User[] users = new User[]
        {
            new User(){ Id = 1, Name = "Test1", Email = "test1@gmail.com", Contact ="11111111", IsActive = true },
            new User(){ Id = 2, Name = "Test2", Email = "test2@gmail.com", Contact ="22222222", IsActive = true },
            new User(){ Id = 3, Name = "Test3", Email = "test3@gmail.com", Contact ="33333333", IsActive = true }
        };

        public static IEnumerable<User> GetAllSource()
        {
            return users;
        }

        public static User GetById()
        {
            return new User() { Id = 1, Name = "Test1", Email = "test1@gmail.com", Contact = "11111111", IsActive = true };
        }

        public static User Insert()
        {
            return new User() { Id = 4, Name = "Test4", Email = "test4@gmail.com", Contact = "44444444", IsActive = true };
        }
    }
}