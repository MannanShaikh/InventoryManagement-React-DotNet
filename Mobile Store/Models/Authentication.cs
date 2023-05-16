using Mobile_Store.DBFactory;
using System.Data;
using System.Data.SqlClient;
using Mobile_Store.Interfaces;
using static Mobile_Store.Models.User;
using System.Security;
using Mobile_Store.DBContext;

namespace Mobile_Store.Models
{
    public class Authentication : IAuthentication
    {
        #region Private Variables
        /// <summary>
        /// Private variables to initialize in constructor
        /// </summary>
        private IDBOperationLibrary _operationLibrary;
        #endregion

        #region Class Instance constructor
        /// <summary>
        /// Class Instance constructor
        /// </summary>
        /// <param name="singletonDBFactory"></param>
        public Authentication(IDBOperationLibrary operationLibrary)
        {
            _operationLibrary = operationLibrary;
        }

        public Authentication() { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Method to check credentials of the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the user credentials are correct </returns>
        public User CheckAuthentication(User user)
        {
            if ( user != null && user.UserName != null && user.Password != null )
            {
                return _operationLibrary.spAuthenticateUser(user);
            }
            else
            {
                return new User();
            }
            
        }

        /// <summary>
        /// Method to change the credentials for the logged in user
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the task succeeds </returns>
        public bool ChangeUserCredentials(User user)
        {
            if (user != null && user.UserName != null && user.Password != null)
            {
                int rowsAffected = _operationLibrary.spChangeUserCredentials(user);
                return rowsAffected > 0 ? true : false; 
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method to Reset user's credentials
        /// </summary>
        /// <param name="user"></param>
        public void ResetCredentials(User user)
        {
            if (user != null && user.UserName != null)
            {
                int rowsAffected = _operationLibrary.spChangeUserCredentials(user);
            }
        }
        #endregion
    }
}
