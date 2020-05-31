using Dapper;
using DSP.Data.Context;
using DSP.Domain.Interfaces;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;

namespace DSP.Data.Repositories
{
    public class VendorCustomersRepository : BaseRepository,IVendorCustomersRepository
    {

        // This is default entity framework implementation for accessing data 
        private DSPMainDbContext _context;

        //This is for dapper implementation
       // protected IDbConnection _dbConnection;
       // protected  readonly string _connectionString = string.Empty;

        public VendorCustomersRepository(DSPMainDbContext dbContext)
        {
            //Entity injection
            _context = dbContext;

            //dapper implementaion
            //_connectionString = "Data Source=DSPMainDb;Initial Catalog=DataManagement;Integrated Security=True";
            //_dbConnection = new SqlConnection(_connectionString);
        }

        public IEnumerable<VendorCustomers> GetAllCustomers()
        {
            //return _context.Customers;
            return dbConnection.Query<VendorCustomers>("SELECT * FROM Customers");
        }


        public VendorCustomers GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
