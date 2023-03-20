using System.ComponentModel.DataAnnotations;

namespace APlus.Data.Model
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Code { get; set; }

        public ICollection<SubscriptionUser> SubscriptionUsers { get; set; }

    }
}
