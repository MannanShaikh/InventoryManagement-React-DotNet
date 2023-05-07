using Mobile_Store.Interfaces;
using Mobile_Store.Structures;

namespace Mobile_Store.Models
{
    public class Supplier : IPerson
    {
        #region Public Properties
        /// <summary>
        /// Public Properties
        /// </summary>
        public Guid ID { get; set; }
        public Name Name { get; set; }
        public string CompanyName { get; set; }
        public Address? Address { get; set; }
        public string? Email { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Method used to add new supplier to the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool AddSupplier(int id)
        {
            return true;
        }

        /// <summary>
        /// Method used to edit existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool Editsupplier(int id)
        {
            return true;
        }

        /// <summary>
        /// Method used to delete existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool Deletesupplier(int id)
        {
            return true;
        }

        /// <summary>
        /// Method used to search existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> supplier type object, with the fetched details </returns>
        public Supplier Searchsupplier(int id)
        {
            return new Supplier() { ID = Guid.NewGuid(), Name = new Name() { FirstName = "", MiddleName = null, LastName = ""}, Address = new Address() { State = "", City = "" }, Email = "" };
        }
        #endregion
    }
}
