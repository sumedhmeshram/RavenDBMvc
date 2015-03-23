using AutoMapper;
using RavenDb.Poco;
using RavenDb.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RavenDb.Web.App_Start.AutoMapperConfig
{
    public class AutoMapperAppConfig
    {
        public static void RegisterAppConfig()
        {
            Mapper.CreateMap<Customer, CustomerViewModel>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(res => res.CustomerId));
        }
    }
}