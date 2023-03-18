using AutoMapper;
using EComm.Services.CouponAPI.Models;
using EComm.Services.CouponAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EComm.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
                //config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                //config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
                //config.CreateMap<Cart, CartDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
