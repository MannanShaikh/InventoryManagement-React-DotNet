using Mobile_Store.DBFactory;
using System.Data;
using System.Data.SqlClient;

namespace Mobile_Store.Models
{
    public class Authentication
    {
        #region Private Variables
        /// <summary>
        /// Private variables to initialize in constructor
        /// </summary>
        private readonly SingletonDBFactory _singletonDBFactory;
        private readonly string ConnectionString;
        private readonly SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        #endregion

        #region Class Instance constructor
        /// <summary>
        /// Class Instance constructor
        /// </summary>
        /// <param name="singletonDBFactory"></param>
        Authentication(SingletonDBFactory singletonDBFactory)
        {
            _singletonDBFactory = singletonDBFactory;
            ConnectionString = _singletonDBFactory.DbInstance();
            sqlConnection = new SqlConnection(ConnectionString);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Method to check credentials of the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the user credentials are correct </returns>
        public bool CheckAuthentication(User user)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = user.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = user.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method to change the credentials for the logged in user
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the task succeeds </returns>
        public bool ChangeUserCredentials(User user)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = user.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = user.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method to Reset user's credentials
        /// </summary>
        /// <param name="user"></param>
        public void ResetCredentials(User user)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = user.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = user.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        #endregion
    }
}
