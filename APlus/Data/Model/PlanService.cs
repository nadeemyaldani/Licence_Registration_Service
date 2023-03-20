using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APlus.Data.Model
{
    public class PlanService
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Service { get; set; }
        [Required]
        public int PlanId { get; set; }
        [ForeignKey("PlanId")]
        public Plan Plan { get; set; }
    }
}
