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
    /// <summary>
    /// Klasa entity definiująca strukturę
    /// tabeli Guest w bazie danych
    /// </summary>
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


        [Required]
        public int GuestAccessId { get; set; }

        [ForeignKey("GuestAccessId")]
        public virtual GuestAccess GuestAccess { get; set; }


        [Required]
        public int GuestBookingId { get; set; }

        [ForeignKey("GuestBookingId")]
        public virtual GuestBooking GuestBooking { get; set; }


        [Required]
        public int GuestCateringId { get; set; }

        [ForeignKey("GuestCateringId")]
        public virtual GuestCatering GuestCatering { get; set; }



    }
}
