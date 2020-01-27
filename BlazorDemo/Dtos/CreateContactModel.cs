using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Dtos
{
    public class CreateContactModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Address { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
