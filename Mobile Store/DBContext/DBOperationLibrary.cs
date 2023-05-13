using Mobile_Store.Interfaces;
using Mobile_Store.Models;
using System.Data;
using System.Data.SqlClient;

namespace Mobile_Store.DBContext
{
    public class DBOperationLibrary : IDBOperationLibrary
    {
        #region Private Variables
        /// <summary>
        /// Private variables to initialize in constructor
        /// </summary>
        private readonly ISingletonDBFactory _singletonDBFactory;
        private readonly string ConnectionString;
        private readonly SqlConnection sqlConnection;
        private SqlCommand? sqlCommand = null;

        #endregion

        #region Class Instance constructor
        /// <summary>
        /// Class Instance constructor
        /// </summary>
        /// <param name="singletonDBFactory"></param>
        public DBOperationLibrary(ISingletonDBFactory singletonDBFactory)
        {
            _singletonDBFactory = singletonDBFactory;
            ConnectionString = _singletonDBFactory.DbInstance();
            sqlConnection = new SqlConnection(ConnectionString);
        }
        #endregion

        #region spAuthenticateUser
        /// <summary>
        /// Method used to AUTHENTICATE USER through Stored Procedure
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns User type object </returns>
        public User spAuthenticateUser(User user)
        {
            using (sqlCommand = new SqlCommand("spAuthenticateUser", sqlConnection))
            {
                bool? permission = null;
                User.Role role = User.Role.Employee;

                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                sqlCommand.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = user.Password;
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Enum.TryParse((string)dataReader["RoleId"], out role);
                        permission = (bool)dataReader["Permission"];
                    }
                }
                sqlConnection.Close();

                User output = new()
                {
                    RoleId = role,
                    Permission = permission
                };
                return output;
            }
        }
        #endregion

        #region spChangeUserCredentials
        /// <summary>
        /// Method used to CHANGE USER CREDENTIALS through Stored Procedure
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns User type object </returns>
        public int spChangeUserCredentials(User user)
        {
            int output = 0;
            using (sqlCommand = new SqlCommand("spChangeUserCredentials", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                sqlCommand.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = user.Password;
                output = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return output;
        }
        #endregion
    }
}
