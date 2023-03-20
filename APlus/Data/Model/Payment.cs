using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APlus.Data.Model
{
    public class Payment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public string PaymentNumber { get; set; }
        [Required]
        public int PlanId { get; set; }
        [Required]
        [ForeignKey("PlanId")]
        public Plan Plan { get; set; }
        [Required]
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        [Required]
        public int Status { get; set; }
        public byte[] Attachment { get; set; }

    }
}
