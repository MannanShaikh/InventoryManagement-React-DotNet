using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile_Store.Models;

namespace Mobile_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private Supplier _supplier;

        #region Class Instance Constructor
        /// <summary>
        /// Instance constructor to initialize objects
        /// </summary>
        /// <param name="supplier"></param>
        SupplierController(Supplier supplier)
        {
            _supplier = supplier;
        }
        #endregion

        #region Add supplier
        /// <summary>
        /// Method to add the supplier record
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns> Returns true if the supplier record is added </returns>
        [HttpPost("Addsupplier")]
        public bool Addsupplier([FromBody] Supplier supplier)
        {
            return _supplier.AddSupplier(supplier);
        }
        #endregion

        #region Edit supplier
        /// <summary>
        /// Method to edit the supplier record
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns> Returns true if the supplier record is edited </returns>
        [HttpPost("Editsupplier")]
        public bool Editsupplier([FromBody] Supplier supplier)
        {
            return _supplier.Editsupplier(supplier);
        }
        #endregion

        #region Delete supplier
        /// <summary>
        /// Method to delete the supplier record
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns> Returns true if the supplier record is deleted </returns>
        [HttpPost("Deletesupplier")]
        public bool Deletesupplier([FromBody] Supplier supplier)
        {
            return _supplier.Deletesupplier(supplier);
        }
        #endregion

        #region Search supplier
        /// <summary>
        /// Method to search the supplier record
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns> Returns supplier type object if the supplier records are found </returns>
        [HttpPost("Searchsupplier")]
        public Supplier Searchsupplier([FromBody] Supplier supplier)
        {
            return _supplier.Searchsupplier(supplier);
        }
        #endregion
    }
}
