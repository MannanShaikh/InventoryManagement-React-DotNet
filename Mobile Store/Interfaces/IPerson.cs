using Mobile_Store.Structures;
using System.ComponentModel.DataAnnotations;

namespace Mobile_Store.Interfaces
{
    #region Person Interface
    public interface IPerson
    {
        public Guid ID { get; set; }
        [Required]
        public Name Name { get; set; }
        public string? Email { get; set; }
        public Address? Address { get; set; }
    }
    #endregion

}
