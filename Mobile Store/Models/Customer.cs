using Mobile_Store.Interfaces;
using Mobile_Store.Structures;
using Mobile_Store.DBFactory;
using System.Data.SqlClient;
using System.Data;

namespace Mobile_Store.Models
{
    public class Customer : IPerson
    {
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
        Customer(SingletonDBFactory singletonDBFactory)
        {
            _singletonDBFactory = singletonDBFactory;
            ConnectionString = _singletonDBFactory.DbInstance();
            sqlConnection = new SqlConnection(ConnectionString);
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
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection)) {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("",SqlDbType.NVarChar).Value = customer.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("",SqlDbType.NVarChar).Value = customer.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method used to edit existing customer details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool EditCustomer(Customer customer)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = customer.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = customer.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method used to delete existing customer details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool DeleteCustomer(Customer customer)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = customer.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = customer.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method used to search existing customer details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> customer type object, with the fetched details </returns>
        public Customer SearchCustomer(Customer customer)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = customer.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = customer.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return new Customer() { ID = Guid.NewGuid(), Name = new Name() { FirstName = "", MiddleName = null, LastName = "" }, Address = new Address() { State = "", City = "" }, Email = "" };
        }
        #endregion

    }
}
