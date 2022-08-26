using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUTriviaGameServer.Models;
using System.Data.SqlClient;

namespace MCUTriviaGameServer.DAO
{
    public class ReviewsSqlDAO //: IReviewDAO
    {
        private readonly string connectionString;

        public ReviewsSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }
    }
}
