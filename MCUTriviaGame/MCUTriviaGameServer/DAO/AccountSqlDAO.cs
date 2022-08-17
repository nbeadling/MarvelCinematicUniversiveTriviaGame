using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.Models;

namespace MCUTriviaGameServer.DAO
{
    public class AccountSqlDAO : IAccountDAO
    {
        private readonly string connectionString;

        public AccountSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Account GetAccountByUserId(int id)
        {
            Account account = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT a.account_id, a.user_id, u.username " +
                    "FROM account a JOIN mcutriviagame_user u ON a.user_id = u.user_id " +
                    "WHERE u.user_id = @user_id;", conn);
                cmd.Parameters.AddWithValue("@user_id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    account = CreateAccountFromReader(reader);
                }

            }
            return account;
        }

        public Account GetAccountByAccountId(int id)
        {
            Account account = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT a.account_id, a.user_id, u.username " +
                    "FROM account a JOIN mcutriviagame_user u ON a.user_id = u.user_id " +
                    "WHERE a.account_id = @account_id;", conn);
                cmd.Parameters.AddWithValue("@account_id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    account = CreateAccountFromReader(reader);
                }

            }
            return account;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT a.account_id, a.user_id, u.username " +
                    "FROM account a JOIN mcutriviagame_user u ON a.user_id = u.user_id", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Account account = CreateAccountFromReader(reader);
                    accounts.Add(account);
                }

            }
            return accounts;
        }
        private Account CreateAccountFromReader(SqlDataReader reader)
        {
            Account account = new Account();
            account.AccountId = Convert.ToInt32(reader["account_id"]);
            account.UserId = Convert.ToInt32(reader["user_id"]);
            account.Username = Convert.ToString(reader["username"]);

            return account;
        }

    }
}
