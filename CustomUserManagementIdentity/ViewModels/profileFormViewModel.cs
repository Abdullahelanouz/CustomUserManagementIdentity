using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CustomUserManagementIdentity.ViewModels
{
    public class profileFormViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]

        [Display(Name = "first name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]

        [Display(Name = "Last name")]
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }
}
