using AutoMapper;
using MikołajRarokZad4.Infrastructure;
using MikołajRarokZad4.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna posiadająca zmienne i metody z których
    /// korzystają wszystkie repozytoria
    /// </summary>
    public abstract class Repository
    {
        //zmienna przechowująca kontekst Bazy danych
        protected readonly DataBaseContext DbContext = new DataBaseContext();

        //zmienna konfiguracji mappera
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));
        //zmienna mappera
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
