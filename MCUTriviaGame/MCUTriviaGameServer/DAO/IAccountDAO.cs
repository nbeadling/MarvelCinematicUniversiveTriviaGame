using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.Models;

namespace MCUTriviaGameServer.DAO
{
    public interface IAccountDAO
    {
        Account GetAccountByUserId(int id);
        Account GetAccountByAccountId(int id);
        List<Account> GetAllAccounts();
    }
}
