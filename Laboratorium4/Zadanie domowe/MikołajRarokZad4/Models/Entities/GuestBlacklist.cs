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
    /// tabeli GuestBlacklist w bazie danych
    /// </summary>
    public class GuestBlacklist
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

       
    }
}
