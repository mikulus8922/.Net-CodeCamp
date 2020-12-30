using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Models.Entities
{
    public class GuestCatering
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool Breakfast { get; set; }

        [Required]
        public bool Lunch { get; set; }

        [Required]
        public bool Dinner { get; set; }


        public virtual ICollection<Guest> Guests { get; set; }

    }
}
