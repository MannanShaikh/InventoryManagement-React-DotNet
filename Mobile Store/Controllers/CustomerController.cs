using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile_Store.Models;

namespace Mobile_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private Customer _customer;

        #region Class Instance Constructor
        /// <summary>
        /// Instance constructor to initialize objects
        /// </summary>
        /// <param name="customer"></param>
        CustomerController(Customer customer)
        {
            _customer = customer;
        }
        #endregion

        #region Add Customer
        /// <summary>
        /// Method to add the customer record
        /// </summary>
        /// <param name="customer"></param>
        /// <returns> Returns true if the customer record is added </returns>
        [HttpPost("AddCustomer")]
        public bool AddCustomer([FromBody] Customer customer)
        {
            return _customer.AddCustomer(customer);
        }
        #endregion

        #region Edit Customer
        /// <summary>
        /// Method to edit the customer record
        /// </summary>
        /// <param name="customer"></param>
        /// <returns> Returns true if the customer record is edited </returns>
        [HttpPost("EditCustomer")]
        public bool EditCustomer([FromBody] Customer customer)
        {
            return _customer.EditCustomer(customer);
        }
        #endregion

        #region Delete Customer
        /// <summary>
        /// Method to delete the customer record
        /// </summary>
        /// <param name="customer"></param>
        /// <returns> Returns true if the customer record is deleted </returns>
        [HttpPost("DeleteCustomer")]
        public bool DeleteCustomer([FromBody] Customer customer)
        {
            return _customer.DeleteCustomer(customer);
        }
        #endregion

        #region Search Customer
        /// <summary>
        /// Method to search the customer record
        /// </summary>
        /// <param name="customer"></param>
        /// <returns> Returns Customer type object if the customer records are found </returns>
        [HttpPost("SearchCustomer")]
        public Customer SearchCustomer([FromBody] Customer customer)
        {
            return _customer.SearchCustomer(customer);
        }
        #endregion
    }
}
