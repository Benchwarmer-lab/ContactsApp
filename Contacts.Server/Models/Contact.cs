using System.ComponentModel.DataAnnotations;

namespace Contacts.Server.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string Street { get; set; }
        public required string ZipCode { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
