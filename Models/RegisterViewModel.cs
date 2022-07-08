using Asp_MVCCore.Attribute;
using System.ComponentModel.DataAnnotations;

namespace Asp_MVCCore.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string? Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and confirmation password does not match")]
        public string? Confirmpassword { get; set; }

        [Required]
        //[DataType(DataType.PhoneNumber)]
        public string? Contact { get; set; }
        
        [Required]
        public string? Country { get; set; }

        [Required]
        public string? City { get; set; }
        
        [Required]
        public string? Gender { get; set; }

        [VallidateCheckBox(ErrorMessage="check accept Tearms")]
        public bool Accepttearm { get; set; }
        
    }
}
