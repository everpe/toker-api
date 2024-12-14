using System.ComponentModel.DataAnnotations;

namespace TokerChat.Api.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(10)]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
