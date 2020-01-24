using Microsoft.AspNetCore.Mvc;
using SampleWebApp_With_NunitTest.Models;
using SampleWebApp_With_NunitTest.Services;
using System.Collections.Generic;

namespace SampleWebApp_With_NunitTest.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Constructor

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region Api Implementation

        [HttpGet("GetAllUser")]
        public IEnumerable<User> GetAllUsers()
        {
            var users = _userService.GetAllUsers();

            return users;
        }

        [HttpGet("GetById")]
        public User GetById(int id)
        {
            var users = _userService.GetById(id);

            return users;
        }

        [HttpGet("Insert")]
        public User AddUser()
        {
            User user = new User();
            user.Name = "Test4";
            user.Email = "test4@gmail.com";
            user.Contact = "44444444";

            _userService.Insert(user);

            return user;
        }

        #endregion

    }
}