using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Models.Entities
{
    class GuestCatering
    {
        [Required]
        public bool Breakfast { get; set; }

        [Required]
        public bool Lunch { get; set; }

        [Required]
        public bool Dinner { get; set; }

        [Required]
        public int GuestId { get; set; }

        [ForeignKey("GuestId")]
        public virtual Guest Guest { get; set; }

        public virtual ICollection<GuestCatering> GuestsCatering { get; set; }
    }
}
