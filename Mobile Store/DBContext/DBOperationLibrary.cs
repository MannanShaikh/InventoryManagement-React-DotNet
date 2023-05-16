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

        #region
        public int spAddUserRecord(User user)
        {
            int output = 0;
            using (sqlCommand = new SqlCommand("spAddUserRecord", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = Guid.NewGuid().ToString();
                sqlCommand.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = user.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("@MiddleName", SqlDbType.VarChar).Value = user.Name.MiddleName;
                sqlCommand.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = user.Name.LastName;
                sqlCommand.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = user.Address.Country;
                sqlCommand.Parameters.AddWithValue("@State", SqlDbType.VarChar).Value = user.Address.State;
                sqlCommand.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = user.Address.City;
                sqlCommand.Parameters.AddWithValue("@ZipCode", SqlDbType.VarChar).Value = user.Address.ZIP_Code;
                sqlCommand.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = user.Email;
                sqlCommand.Parameters.AddWithValue("@Role", SqlDbType.VarChar).Value = user.RoleId;
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", SqlDbType.Date).Value = user.DateOfBirth;
                sqlCommand.Parameters.AddWithValue("@Permission", SqlDbType.Bit).Value = user.Permission;
                sqlCommand.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = user.UserName;
                sqlCommand.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = user.Password;
                output = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return output;
        }
        #endregion

        #region
        public int spEditUserRecord(User user)
        {
            int output = 0;
            using (sqlCommand = new SqlCommand("spEditUserRecord", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //DEPRECATE -- UPDATE SP ACCORDINGLY
                //sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = user.ID;
                sqlCommand.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = user.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("@MiddleName", SqlDbType.VarChar).Value = user.Name.MiddleName;
                sqlCommand.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = user.Name.LastName;
                sqlCommand.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = user.Address.Country;
                sqlCommand.Parameters.AddWithValue("@State", SqlDbType.VarChar).Value = user.Address.State;
                sqlCommand.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = user.Address.City;
                sqlCommand.Parameters.AddWithValue("@ZipCode", SqlDbType.VarChar).Value = user.Address.ZIP_Code;
                sqlCommand.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = user.Email;
                sqlCommand.Parameters.AddWithValue("@Role", SqlDbType.VarChar).Value = user.RoleId;
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", SqlDbType.Date).Value = user.DateOfBirth;
                sqlCommand.Parameters.AddWithValue("@Permission", SqlDbType.Bit).Value = user.Permission;
                sqlCommand.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = user.UserName;
                sqlCommand.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = user.Password;
                output = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return output;
        }
        #endregion
    }
}
