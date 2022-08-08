using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.DAO;
using MCUTriviaGameServer.Models;
using Microsoft.AspNetCore.Authorization;

namespace MCUTriviaGameServer.Controllers
{
    [Route("users")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private IUserDAO userDao;

        public UsersController(IUserDAO userDao)
        {
            this.userDao = userDao;
        }

        [HttpGet()]
        public List<User> ListAllUsers()
        {
            return userDao.GetUsers();
        }
    }
}
