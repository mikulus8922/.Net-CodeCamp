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
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Klasa z profilem mapowania, zawierająca konfiguracje map
        /// </summary>
        public MapperProfile()
        {
            
            CreateMap<GuestBlacklist, BlacklistViewModel>();


            CreateMap<Room, RoomViewModel>();



            CreateMap<Guest, GuestAdminViewModel>()
                .ForMember(g => g.Number, opt => opt.MapFrom(src => src.Room.Number))
                .ForMember(g => g.BookedIn, opt => opt.MapFrom(src => src.GuestBooking.BookedIn))
                .ForMember(g => g.BookedOut, opt => opt.MapFrom(src => src.GuestBooking.BookedOut))
                .ForMember(g => g.BookedIn, opt => opt.MapFrom(src => src.GuestBooking.BookedIn))
                .ForMember(g => g.Breakfast, opt => opt.MapFrom(src => src.GuestCatering.Breakfast))
                .ForMember(g => g.Lunch, opt => opt.MapFrom(src => src.GuestCatering.Lunch))
                .ForMember(g => g.Dinner, opt => opt.MapFrom(src => src.GuestCatering.Dinner))
                .ForMember(g => g.GymAccess, opt => opt.MapFrom(src => src.GuestAccess.GymAccess))
                .ForMember(g => g.SpaAccess, opt => opt.MapFrom(src => src.GuestAccess.SpaAccess))
                .ForMember(g => g.PoolAccess, opt => opt.MapFrom(src => src.GuestAccess.PoolAccess))
                ;
                

            CreateMap<Guest, GuestCateringViewModel>()
                .ForMember(g => g.Breakfast, opt => opt.MapFrom(src => src.GuestCatering.Breakfast))
                .ForMember(g => g.Lunch, opt => opt.MapFrom(src => src.GuestCatering.Lunch))
                .ForMember(g => g.Dinner, opt => opt.MapFrom(src => src.GuestCatering.Dinner))
                ;


            CreateMap<Worker, WorkerViewModel>()
                .ForMember(w => w.WorkPosition, opt => opt.MapFrom(src => src.WorkerLoginData.WorkPosition))
                ;



        }
    }
}
