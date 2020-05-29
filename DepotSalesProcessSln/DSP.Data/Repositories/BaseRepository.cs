using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DSP.Data.Repositories
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection dbConnection;

        public BaseRepository()
        {
            string connectionString = "Server=DESKTOP-F4EP065\\SQLEXPRESS;Database=DSPMainDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            dbConnection = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
           //Implement any dispoable content 
        }
    }
}
