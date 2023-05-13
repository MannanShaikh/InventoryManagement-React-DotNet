using System.Data.SqlClient;
using Mobile_Store.Models;
using Mobile_Store.Structures;
using Mobile_Store.Interfaces;

namespace Mobile_Store.DBFactory
{
    public class SingletonDBFactory : ISingletonDBFactory
    {
        string? instance = null;
        private readonly IConfiguration _configuration;

        public SingletonDBFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string DbInstance()
        {
            if (instance == null)
            {
                instance = _configuration.GetConnectionString("DefaultConnection");
            }
            return instance;
        }
    }

}
