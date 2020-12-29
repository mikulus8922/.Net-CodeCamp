using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MikołajRarokZad4.Models.Entities;

namespace MikołajRarokZad4.Models.Entities
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Required]
        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

        public virtual ICollection<GuestAccess> GuestsAccess { get; set; }

        public virtual ICollection<GuestBooking> GuestsBooking { get; set; }

        public virtual ICollection<GuestCatering> GuestsCatering { get; set; }

    }
}
