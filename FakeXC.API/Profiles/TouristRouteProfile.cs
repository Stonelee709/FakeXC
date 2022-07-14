using AutoMapper;
using FakeXC.API.Dtos;
using FakeXC.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.Profiles
{
    public class TouristRouteProfile:Profile
    {
        public TouristRouteProfile()
        {
            CreateMap<TouristRoute, TouristRouteDto>()
                .ForMember(dest => dest.Price,
                opt => opt.MapFrom(src => src.OriginalPrice * (decimal)(src.DiscountPercentage ?? 1)))
                .ForMember(
                dest => dest.TravelDays,
                opt => opt.MapFrom(src => src.TravelDays.ToString())
                )
                .ForMember(
                  dest => dest.TripType,
                opt => opt.MapFrom(src => src.TripType.ToString())
                )
                 .ForMember(
                  dest => dest.DepatureCity,
                opt => opt.MapFrom(src => src.DepatureCity.ToString())
                );
            CreateMap<TouristRouteForCreationDto, TouristRoute>()
                .ForMember(
                dest => dest.Id,
                opt => opt.MapFrom(src => Guid.NewGuid())
                );
            CreateMap<TouristRouteForUpdateDto, TouristRoute>();
            CreateMap< TouristRoute,TouristRouteForUpdateDto > ();
        }
    }
}
