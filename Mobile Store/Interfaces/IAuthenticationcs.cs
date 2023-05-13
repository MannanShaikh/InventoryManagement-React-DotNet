using Mobile_Store.DBFactory;
using Mobile_Store.Models;
using System.Data.SqlClient;
using System.Data;

namespace Mobile_Store.Interfaces
{
    public interface IAuthentication
    {

        #region Public Methods
        /// <summary>
        /// Method to check credentials of the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the user credentials are correct </returns>
        public User CheckAuthentication(User user);

        /// <summary>
        /// Method to change the credentials for the logged in user
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the task succeeds </returns>
        public bool ChangeUserCredentials(User user);

        /// <summary>
        /// Method to Reset user's credentials
        /// </summary>
        /// <param name="user"></param>
        public void ResetCredentials(User user);
        #endregion
    }
}
