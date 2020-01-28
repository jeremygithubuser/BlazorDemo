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
        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "The phone number should be in format xxx-xxx-xxxx")]
        public string PhoneNumber { get; set; }
    }
}
