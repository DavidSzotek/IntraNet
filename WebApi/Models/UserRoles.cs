using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class UserRole
    {
        public int Id { get; set; }

        [Required]
        public int IntranetUserId { get; set; }
        [Required]
        public IntranetUser IntranetUser { get; set; } = null!;

        [Required]
        public int RoleId { get; set; }
        [Required]
        public Role Role { get; set; } = null!;

        [Required]
        public int OfficeId { get; set; }
        [Required]
        public Office Office { get; set; } = null!;
    }
}
