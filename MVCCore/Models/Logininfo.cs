using System.ComponentModel.DataAnnotations;

namespace MVCCore.Models
{
    public class Logininfo
    {
        [Required(ErrorMessage = "Use your ID")]
        [MinLength(6, ErrorMessage = "The length of your ID is required to be longer than 6")]
        [Display(Name = "UserId")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Use your Password")]
        [MinLength(6, ErrorMessage = "The length of your Password is required to be longer than 6")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}   