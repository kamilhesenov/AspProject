
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AspProject.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
    }
}
