using Mobile_Store.DBFactory;
using Mobile_Store.Interfaces;
using Mobile_Store.Structures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

namespace Mobile_Store.Models
{
    public class User : IPerson
    {
        #region LookUpTable
        /// <summary>
        /// Lookup Table
        /// </summary>
        public enum Role
        {
            Admin,
            Employee
        }
        #endregion

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
        User(SingletonDBFactory singletonDBFactory)
        {
            _singletonDBFactory = singletonDBFactory;
            ConnectionString = _singletonDBFactory.DbInstance();
            sqlConnection = new SqlConnection(ConnectionString);
        }

        public User()
        {
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Public Properties
        /// </summary>
        public Guid? ID { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public string? Email { get; set; }
        public Role? RoleId { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public bool? Permission { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Method used to add new user to the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool AddUser(User user)
        {
            using (sqlCommand = new SqlCommand("[dbo].[spAddUserRecord]", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = user.ID;
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
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method used to edit existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool EditUser(User user)
        {
            using (sqlCommand = new SqlCommand("[dbo].[spEditUserRecord]", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.VarChar).Value = user.ID;
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
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method used to delete existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool DeleteUser(User user)
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
        /// Method used to search existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> User type object, with the fetched details </returns>
        public User SearchUser(User user)
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
            return new User() { ID = Guid.NewGuid(), Name = new Name() { FirstName = "", MiddleName = null, LastName = ""}, Address = new Address() { State = "", City = "", Country = "", ZIP_Code = 0 }, Email = "" };
        }
        #endregion
    }
}