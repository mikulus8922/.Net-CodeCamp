using MikołajRarokZad4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories.Interfaces
{
    public interface IGuestsRepositoryCatering
    {
        /// <summary>
        /// Abstrakcyjna metoda pozwalajaca zwrocić
        /// tabelę gości
        /// </summary>
        /// <returns></returns>
        List<GuestCateringViewModel> GetGuests();


    }
}
