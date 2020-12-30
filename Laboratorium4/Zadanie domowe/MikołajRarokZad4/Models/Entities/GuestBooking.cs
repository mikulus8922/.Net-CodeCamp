using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Models.Entities
{
    public class GuestBooking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime BookedIn { get; set; }

        [Required]
        public DateTime BookedOut { get; set; }

        public virtual ICollection<Guest> Guests { get; set; }

    }
}
