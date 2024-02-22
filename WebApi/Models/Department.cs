using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Department
    {
        public int Id { get; set; }


        [Required] 
        public string Name { get; set; }


        [Required]
        public int OfficeId { get; set; }
        [Required]
        public Office Office { get; set; }

        public List<IntranetUser> IntranetUsers { get; set; }
    }
}
