using Mobile_Store.Models;
using Mobile_Store.Structures;
using System.Data.SqlClient;
using System.Data;

namespace Mobile_Store.Interfaces
{
    public interface ISupplier
    {
        #region Public Properties
        /// <summary>
        /// Public Properties
        /// </summary>
        public Guid? ID { get; set; }
        public Name Name { get; set; }
        public string? CompanyName { get; set; }
        public Address Address { get; set; }
        public string? Email { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Method used to add new supplier to the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool AddSupplier(Supplier supplier);

        /// <summary>
        /// Method used to edit existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool Editsupplier(Supplier supplier);

        /// <summary>
        /// Method used to delete existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool Deletesupplier(Supplier supplier);

        /// <summary>
        /// Method used to search existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> supplier type object, with the fetched details </returns>
        public Supplier Searchsupplier(Supplier supplier);
        #endregion
    }
}
