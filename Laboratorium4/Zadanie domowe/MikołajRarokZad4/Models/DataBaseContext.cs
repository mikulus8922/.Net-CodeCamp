using MikołajRarokZad4.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("ConnectionString")
        {
        }

        public DbSet<GuestBlacklist> GuestsBlacklist { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Guest> Guests { get; set; }

        public DbSet<GuestBooking> GuestsBooking { get; set; }

        public DbSet<GuestAccess> GuestsAccess { get; set; }

        public DbSet<GuestCatering> GuestsCatering { get; set; }

        public DbSet<WorkerLoginData> WorkersLoginData { get; set; }

        public DbSet<Worker> Workers { get; set; }

    }
}
