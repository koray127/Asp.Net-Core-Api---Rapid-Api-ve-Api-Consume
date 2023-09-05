using AutoMapper;
using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUl.Dtos.AboutDto;
using HotelProjectWebUl.Dtos.AppUserDto;
using HotelProjectWebUl.Dtos.BookingDto;
using HotelProjectWebUl.Dtos.GuestDto;
using HotelProjectWebUl.Dtos.LoginDto;
using HotelProjectWebUl.Dtos.RegisterDto;
using HotelProjectWebUl.Dtos.ServiceDto;
using HotelProjectWebUl.Dtos.StaffDto;
using HotelProjectWebUl.Dtos.SubscribeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUl.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            CreateMap<ResultAppUserDto, Guest>().ReverseMap();




        }
    }
}
