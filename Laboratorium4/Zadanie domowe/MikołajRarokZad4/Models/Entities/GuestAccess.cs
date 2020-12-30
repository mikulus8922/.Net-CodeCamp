using MikołajRarokZad4.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Models.Entities
{
    /// <summary>
    /// Klasa entity definiująca strukturę
    /// tabeli GuestAccess w bazie danych
    /// </summary>
    public class GuestAccess
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool GymAccess { get; set; }

        [Required]
        public bool SpaAccess { get; set; }

        [Required]
        public bool PoolAccess { get; set; }


        public virtual ICollection<Guest> Guests { get; set; }


    }
}
