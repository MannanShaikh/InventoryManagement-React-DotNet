namespace Mobile_Store.Models
{
    public class Authentication
    {
        #region Public Methods
        /// <summary>
        /// Method to check credentials of the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the user credentials are correct </returns>
        public bool CheckAuthentication(User user)
        {
            return true;
        }

        /// <summary>
        /// Method to change the credentials for the logged in user
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the task succeeds </returns>
        public bool ChangeUserCredentials(User user)
        {
            return true;
        }

        /// <summary>
        /// Method to Reset user's credentials
        /// </summary>
        /// <param name="user"></param>
        public void ResetCredentials(User user)
        {

        }
        #endregion
    }
}
