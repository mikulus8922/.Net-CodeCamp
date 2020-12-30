using MikołajRarokZad4.Models.Entities;
using MikołajRarokZad4.Repositories.Interfaces;
using MikołajRarokZad4.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Publiczna klasa definiująca metodody związane z cateringiem
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class GuestsRepositoryCatering : Repository, IGuestsRepositoryCatering
    {
        /// <summary>
        /// Metoda zwracająca tabelę
        /// gości w wersji "admin"
        /// </summary>
        /// <returns></returns>
        public List<GuestCateringViewModel> GetGuests()
        {
            List<Guest> guests = DbContext.Guests.ToList();
            return Mapper.Map<List<Guest>, List<GuestCateringViewModel>>(guests);
        }

    }
}
