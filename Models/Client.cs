using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace a.Models
{
    public enum Gender
    {
        M, F, U
    }
    public class Client
    {

        [Key]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime Dob { get; set; }

        public string Hkid { get; set; }
                
        public string Email { get; set; }

        public string MobileNo { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
