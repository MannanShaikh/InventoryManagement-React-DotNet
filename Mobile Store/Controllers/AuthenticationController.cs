﻿using Microsoft.AspNetCore.Mvc;
using Mobile_Store.Models;

namespace Mobile_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        #region Test
        [HttpGet(Name = "Test")]
        public string Get()
        {
            return "Hello World";
        }
        #endregion

        #region Check Authentication
        /// <summary>
        /// Method to verify user
        /// </summary>
        /// <param name="user"> User type object </param>
        /// <returns> Returns true if user is authentic/genuine </returns>
        [HttpPost("CheckAuthentication")]
        public bool CheckAuthentication([FromBody] User user)
        {
            return true;
        }
        #endregion

        #region Change User Credientials
        /// <summary>
        /// Method to change credientials for logged in user
        /// </summary>
        /// <param name="user"> User Type object </param>
        /// <returns> Returns true if credientials are successfully changed </returns>
        [HttpPost("ChangeUserCredentials")]
        public bool ChangeUserCredentials([FromBody] User user)
        {
            return true;
        }
        #endregion

        #region Reset Credentials
        
        [HttpPost("ResetCredentials")]
        public void ResetCredentials([FromBody] User user)
        {

        }
        #endregion
    }
}