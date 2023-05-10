using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile_Store.Models;

namespace Mobile_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private User _user;

        #region Class Instance Constructor
        /// <summary>
        /// Instance constructor to initialize objects
        /// </summary>
        /// <param name="user"></param>
        UserController(User user)
        {
            _user = user;
        }
        #endregion

        #region Add user
        /// <summary>
        /// Method to add the user record
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the user record is added </returns>
        [HttpPost("Adduser")]
        public bool Adduser([FromBody] User user)
        {
            return _user.AddUser(user);
        }
        #endregion

        #region Edit user
        /// <summary>
        /// Method to edit the user record
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the user record is edited </returns>
        [HttpPost("Edituser")]
        public bool Edituser([FromBody] User user)
        {
            return _user.EditUser(user);
        }
        #endregion

        #region Delete user
        /// <summary>
        /// Method to delete the user record
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns true if the user record is deleted </returns>
        [HttpPost("Deleteuser")]
        public bool Deleteuser([FromBody] User user)
        {
            return _user.DeleteUser(user);
        }
        #endregion

        #region Search user
        /// <summary>
        /// Method to search the user record
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Returns user type object if the user records are found </returns>
        [HttpPost("Searchuser")]
        public User Searchuser([FromBody] User user)
        {
            return _user.SearchUser(user);
        }
        #endregion
    }
}
