using System.Collections.Generic;
using MCUTriviaGameServer.Models;

namespace MCUTriviaGameServer.DAO
{
    public interface IUserDAO
    {
        User GetUser(string username);
        User AddUser(string username, string password);
        User GetUserIDByUserName(string username);
        List<User> GetUsers();
    }
}
