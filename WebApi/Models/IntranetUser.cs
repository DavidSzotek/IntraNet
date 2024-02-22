using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class IntranetUser
    {
        public int Id { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string FirstName { get; set;}

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Required]
        public string UserName { get; set; }

        [MaxLength(20)]
        [Required]
        public string NormalizedUserName { get; set; }


        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [MaxLength(20)]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public DateOnly ActivationDate { get; set; }

        [Required]
        public bool IsManager { get; set; }

        [Required]
        public bool IsDirector { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public Department Department { get; set; } = null!;


        public List<UserRole> UserRoles { get; set; } = null!;
    }
}
