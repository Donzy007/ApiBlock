using ApiBlock.Models;
using AutoMapper;
using ApiBlock.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiBlock.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}