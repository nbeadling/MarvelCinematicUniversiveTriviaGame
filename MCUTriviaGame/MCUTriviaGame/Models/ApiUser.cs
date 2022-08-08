using System;
using System.Collections.Generic;
using System.Text;

namespace MCUTriviaGame.Models
{
    public class ApiUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
