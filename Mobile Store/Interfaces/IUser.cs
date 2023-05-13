using Mobile_Store.Structures;
using Mobile_Store.Models;
using static Mobile_Store.Models.User;

namespace Mobile_Store.Interfaces
{
    public interface IUser
    {
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
        public bool AddUser(User user);

        /// <summary>
        /// Method used to edit existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool EditUser(User user);

        /// <summary>
        /// Method used to delete existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool DeleteUser(User user);

        /// <summary>
        /// Method used to search existing user details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> User type object, with the fetched details </returns>
        public User SearchUser(User user);
        #endregion
    }
}
