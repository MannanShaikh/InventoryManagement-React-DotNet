using Mobile_Store.Structures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mobile_Store.Interfaces
{
    #region Person Interface
    /// <summary>
    /// Person Interface
    /// </summary>
    public interface IPerson
    {
        public Guid? ID { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public string? Email { get; set; }
    }
    #endregion

}
