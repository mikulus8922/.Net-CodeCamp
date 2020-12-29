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
    class GuestAccess
    {
        [Required]
        public bool GymAccess { get; set; }

        [Required]
        public bool SpaAccess { get; set; }

        [Required]
        public bool PoolAccess { get; set; }

        [Required]
        public int GuestId { get; set; }

        [ForeignKey("GuestId")]
        public virtual Guest Guest { get; set; }

        public virtual ICollection<GuestAccess> GuestsAccess { get; set; }
    }
}
