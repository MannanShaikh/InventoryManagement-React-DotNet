using Mobile_Store.Interfaces;
using Mobile_Store.Structures;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Data;
using Mobile_Store.DBFactory;

namespace Mobile_Store.Models
{
    public class Supplier : IPerson
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
        Supplier(SingletonDBFactory singletonDBFactory)
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
        public bool AddSupplier(Supplier supplier)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = supplier.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = supplier.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method used to edit existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool Editsupplier(Supplier supplier)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = supplier.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = supplier.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method used to delete existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Boolean Value based on task completion </returns>
        public bool Deletesupplier(Supplier supplier)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = supplier.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = supplier.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Method used to search existing supplier details in the records
        /// </summary>
        /// <param name="id"></param>
        /// <returns> supplier type object, with the fetched details </returns>
        public Supplier Searchsupplier(Supplier supplier)
        {
            using (sqlCommand = new SqlCommand("PROC NAME", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = supplier.Name.FirstName;
                sqlCommand.Parameters.AddWithValue("", SqlDbType.NVarChar).Value = supplier.Address.City;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return new Supplier() { ID = Guid.NewGuid(), Name = new Name() { FirstName = "", MiddleName = null, LastName = ""}, Address = new Address() { State = "", City = "" }, Email = "" };
        }
        #endregion
    }
}
