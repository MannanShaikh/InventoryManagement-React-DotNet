using Mobile_Store.Models;
using System.Data.SqlClient;
using System.Data;

namespace Mobile_Store.Interfaces
{
    public interface IDBOperationLibrary
    {
        public User spAuthenticateUser(User user);
        public int spChangeUserCredentials(User user);
    }
}
