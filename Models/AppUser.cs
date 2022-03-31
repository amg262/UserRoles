using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserRoles.Models
{
    public class AppUser : IdentityUser
    {

    }

    public class CreateUser
    {
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}