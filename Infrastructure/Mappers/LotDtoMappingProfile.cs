﻿using ApplicationCore.DTO;
using ApplicationCore.Entities;
using AutoMapper;

namespace Infrastructure.Mappers
{
    public class LotDtoMappingProfile : Profile
    {
        public LotDtoMappingProfile()
        {
            CreateMap<LotDto, Lot>().ReverseMap();
        }
    }
}