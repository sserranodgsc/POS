﻿using AutoMapper;
using POS.Application.Dtos.Requests;
using POS.Application.Dtos.Responses;
using POS.Domain.Entities;
using POS.Infraestructure.Commons.Bases.Responses;
using POS.Utilities.Static;

namespace POS.Application.Mappers
{
    public class CategoryMappingsProfile : Profile
    {
        public CategoryMappingsProfile()
        {
            CreateMap<Category, CategoryResponseDto>()
                .ForMember(x => x.StateCategory,
                    x => x.MapFrom(y => y.State.Equals((int)StateTypes.Activo) ? "Activo" : "Inactivo"))
                .ReverseMap();

            CreateMap<BaseEntityResponse<Category>, BaseEntityResponse<CategoryResponseDto>>()
                .ReverseMap();

            CreateMap<CategoryRequestDto, Category>();

            CreateMap<Category, CategorySelectResponseDto>()
                .ReverseMap();
        }
    }
}
