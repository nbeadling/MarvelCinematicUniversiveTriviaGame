using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
    }
}
