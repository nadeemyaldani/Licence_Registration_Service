using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace APlus.Data.Model
{
    public class Plan
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Users { get; set; }
        [Required]
        [Precision(18, 2)]
        public decimal Cost { get; set; }
        [Required]
        public string Currency { get; set; }
    }
}
