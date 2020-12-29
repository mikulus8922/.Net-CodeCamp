﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.ViewModels
{
    class GuestAdminViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Number { get; set; }
        public DateTime BookedIn { get; set; }
        public DateTime BookedOut { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }
        public bool GymAccess { get; set; }
        public bool SpaAccess { get; set; }
        public bool PoolAccess { get; set; }

    }
}
