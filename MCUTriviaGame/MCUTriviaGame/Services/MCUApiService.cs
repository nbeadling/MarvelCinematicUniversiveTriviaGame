using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using MCUTriviaGame.Models;
using MCUTriviaGame.Services;

namespace MCUTriviaGame.Services
{
    public class MCUApiService : AuthenticatedApiService
    {
        public readonly string ApiUrl;

        public MCUApiService(string apiUrl) : base(apiUrl) { }

        // Add methods to call api here...
        public List<Account> GetAccounts()
        {
            RestRequest request = new RestRequest("accounts");
            IRestResponse<List<Account>> response = client.Get<List<Account>>(request);

            CheckForError(response);
            return response.Data;

        }

        public Account GetMyAccount()
        {
            RestRequest request = new RestRequest("/accounts/myaccount");
            IRestResponse<Account> response = client.Get<Account>(request);

            CheckForError(response);
            return response.Data;
        }
        public List<Users> GetAllUsers()
        {
            RestRequest request = new RestRequest("users");
            IRestResponse<List<Users>> response = client.Get<List<Users>>(request);

            CheckForError(response);
            return response.Data;
        }
    }
}
