using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace MCUTriviaGameServer.Models
{
    public class Account
    {
        public int AccountId { get; set; }  

        public int UserId { get; set; } 

        public string Username { get; set; }    

        public Account()
        {

        }

        public Account(int accountId, int userId, string username)
        {
            AccountId = accountId;
            UserId = userId;
            Username = username;
        }
    }
}
