using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MCUTriviaGameServer.DAO;
using MCUTriviaGameServer.Models;
using Microsoft.AspNetCore.Authorization; 


namespace MCUTriviaGameServer.Controllers
{
    [Route("accounts")]
    [ApiController]
    //[Authorize]
    public class AccountsController : ControllerBase
    {
        private IAccountDAO accountDao;

        public AccountsController(IAccountDAO accountDao)
        {
            this.accountDao = accountDao;
        }

        [HttpGet]
        public List<Account> ListAllAccounts()
        {
            return accountDao.GetAllAccounts();
        }

        [HttpGet("/accounts/myaccount")]
        public Account GetMyAccount()
        {
            string userId = User.FindFirst("sub")?.Value;

            int userIdNumber = Convert.ToInt32(userId);
            Account account = accountDao.GetAccountByUserId(userIdNumber);
            return account;
        }

        [HttpGet("/accounts/users/{id}")]
        public Account GetAccountByUserId(int id)
        {
            return accountDao.GetAccountByAccountId(id);
        }
    }
}
