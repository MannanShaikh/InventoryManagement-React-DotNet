using Mobile_Store.DBFactory;
using Mobile_Store.Interfaces;
using Mobile_Store.Structures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

namespace Mobile_Store.Models
{
    public class User : IPerson, IUser
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
        private IDBOperationLibrary _operationLibrary;
        #endregion

        #region Class Instance constructor
        /// <summary>
        /// Class Instance constructor
        /// </summary>
        /// <param name="singletonDBFactory"></param>
        public User(IDBOperationLibrary operationLibrary)
        {
            _operationLibrary = operationLibrary;
        }
        public User() { }
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
            if (user != null)
            {
                int rowsAffected = _operationLibrary.spAddUserRecord(user);
                return rowsAffected > 0 ? true : false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method used to edit existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool EditUser(User user)
        {
            if (user != null && user.UserName != null & user.Password != null)
            {
                int rowsAffected = _operationLibrary.spAddUserRecord(user);
                return rowsAffected > 0 ? true : false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method used to delete existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool DeleteUser(User user)
        {
            return true;
        }

        /// <summary>
        /// Method used to search existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> User type object, with the fetched details </returns>
        public User SearchUser(User user)
        {
            return new User() { ID = Guid.NewGuid(), Name = new Name() { FirstName = "", MiddleName = null, LastName = ""}, Address = new Address() { State = "", City = "", Country = "", ZIP_Code = 0 }, Email = "" };
        }
        #endregion
    }
}