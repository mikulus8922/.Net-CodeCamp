using AutoMapper;
using MikołajRarokZad4.Models.Entities;
using MikołajRarokZad4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Infrastructure
{
    class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //mapa dla modelu blacklist
            CreateMap<GuestBlacklist, BlacklistViewModel>();



        }
    }
}
