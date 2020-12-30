using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Models.Entities
{
    /// <summary>
    /// Klasa entity definiująca strukturę
    /// tabeli Room w bazie danych
    /// </summary>
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int RoomCapacity { get; set; }

        [Required]
        public int Floor { get; set; }

        public virtual ICollection<Guest> Guests { get; set; }
    }
}
