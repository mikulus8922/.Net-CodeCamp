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
    /// tabeli WorkerLoginData w bazie danych
    /// </summary>
    public class WorkerLoginData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string WorkPosition { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
