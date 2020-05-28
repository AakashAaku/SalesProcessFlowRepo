using Dapper;
using DSP.Data.Context;
using DSP.Domain.Interfaces;
using DSP.Domain.Interfaces.BaseInterface;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DSP.Data.Repositories
{
    public class ITN_OPRORepository : BaseRepository, IITN_OPRORepository
    {
        // This is default entity framework implementation for accessing data 
        private DSPMainDbContext _context;

        //This is for dapper implementation
        // protected IDbConnection _dbConnection;
        // protected  readonly string _connectionString = string.Empty;

        public ITN_OPRORepository(DSPMainDbContext dbContext)
        {
            //Entity injection
            _context = dbContext;

            //dapper implementaion
            //_connectionString = "Data Source=DSPMainDb;Initial Catalog=DataManagement;Integrated Security=True";
            //_dbConnection = new SqlConnection(_connectionString);
        }
    }
}
