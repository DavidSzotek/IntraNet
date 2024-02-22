using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Role
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string NormalizedName { get; set; } = null!;

        public List<UserRole> UserRoles { get; set; } = null!;
    }
}

