using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APlus.Data.Model
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        //public int UserId { get; set; }
        //public User User { get; set; }
    }
}
