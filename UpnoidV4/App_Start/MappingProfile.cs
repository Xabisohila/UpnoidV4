using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using UpnoidV4.Dto;
using UpnoidV4.Dtos;
using UpnoidV4.Models;

namespace UpnoidV4.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();


            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}