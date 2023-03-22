using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APlus.Data.Model
{
    public class Subscription
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int Status { get; set; }
        public int Commitment { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; } 
        [Required]
        public DateTime ExpiryDate { get; set; }
        public List<PlanService> Services { get; set; } = new List<PlanService>();
        public SubscriptionUser SubscriptionUser { get; set; } = new SubscriptionUser();
        public int PlanId { get; set; }
        [ForeignKey("PlanId")]
        public Plan Plan { get; set; } = new Plan();

    }
}
