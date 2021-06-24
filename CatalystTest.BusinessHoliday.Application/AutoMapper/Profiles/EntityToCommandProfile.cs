using AutoMapper;
using CatalystTest.BusinessHoliday.Domain.Commands;
using CatalystTest.BusinessHoliday.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Application.AutoMapper.Profiles
{
    public class EntityToCommandProfile : Profile
    {
        public EntityToCommandProfile()
        {
            CreateMap<Holiday, CreateHolidayCommand>()
                .ReverseMap();

            CreateMap<Holiday, UpdateHolidayCommand>()
                .ReverseMap();
        }
    }
}
