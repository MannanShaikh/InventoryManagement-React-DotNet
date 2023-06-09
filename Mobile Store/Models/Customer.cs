﻿using Mobile_Store.Interfaces;
using Mobile_Store.Structures;
using Mobile_Store.DBFactory;
using System.Data.SqlClient;
using System.Data;

namespace Mobile_Store.Models
{
    public class Customer : IPerson, ICustomer
    {
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
        public Customer(IDBOperationLibrary operationLibrary)
        {
            _operationLibrary = operationLibrary;
        }
        public Customer() { }
        #endregion

        #region Public Properties
        /// <summary>
        /// Public Properties
        /// </summary>
        public Guid? ID { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public string? Email { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Method used to add new customer to the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool AddCustomer(Customer customer)
        {
            return true;
        }

        /// <summary>
        /// Method used to edit existing customer details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool EditCustomer(Customer customer)
        {
            return true;
        }

        /// <summary>
        /// Method used to delete existing customer details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool DeleteCustomer(Customer customer)
        {
            return true;
        }

        /// <summary>
        /// Method used to search existing customer details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> customer type object, with the fetched details </returns>
        public Customer SearchCustomer(Customer customer)
        {
            return new Customer() { ID = Guid.NewGuid(), Name = new Name() { FirstName = "", MiddleName = null, LastName = "" }, Address = new Address() { State = "", City = "" }, Email = "" };
        }
        #endregion

    }
}
