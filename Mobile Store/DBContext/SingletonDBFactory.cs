using System.Data.SqlClient;
using Mobile_Store.Models;
using Mobile_Store.Structures;

namespace Mobile_Store.DBFactory
{
    public class SingletonDBFactory
    {
        string? instance;
        private readonly IConfiguration _configuration;
        // Constructor is 'protected'
        protected SingletonDBFactory()
        {
            instance = null;
        }
        public string DbInstance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = _configuration.GetConnectionString("DefaultConnection");
            }
            return instance;
        }
    }

}
