using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APlus.Data.Model
{
    public class SubscriptionUser
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string AccountNo { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string DisplayName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public int CountryId { get; set; }
        [Required]
        [ForeignKey("CountryId")]
        public virtual Country Country { get; }
        [Required]
        public int SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public virtual Subscription Subscription { get; }
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; }
        [Required]
        public string Organization { get; set; }

        public byte[]? UserProfilePicture { get; set; }

        //public int ApplicationUserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }
    }


}
