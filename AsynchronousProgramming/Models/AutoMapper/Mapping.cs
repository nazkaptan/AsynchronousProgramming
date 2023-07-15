﻿using AsynchronousProgramming.Models.DTOs;
using AsynchronousProgramming.Models.Entities.Concrete;
using AsynchronousProgramming.Models.VMs;
using AutoMapper;

namespace AsynchronousProgramming.Models.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryVM>().ReverseMap();

            CreateMap<Page, CreatePageDTO>().ReverseMap();
            CreateMap<Page, UpdatePageDTO>().ReverseMap();
            CreateMap<Page, PageVM>().ReverseMap();

            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
        }
    }
}
