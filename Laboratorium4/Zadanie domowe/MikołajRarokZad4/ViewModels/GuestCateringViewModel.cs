using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.ViewModels
{
    /// <summary>
    /// Model gościa w wersji admin przeznaczony do użytku
    /// w profilu menadżera cateringu
    /// </summary>
    public class GuestCateringViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }
    }
}
