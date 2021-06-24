using AutoMapper;
using CatalystTest.BusinessHoliday.Application.AutoMapper.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration ConfigureMappings()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => {
                cfg.AddProfile(new EntityToCommandProfile());
            });
            return mapperConfiguration;
        }
    }
}
