using CatalystTest.BusinessHoliday.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Web.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            var mapper = AutoMapperConfiguration.ConfigureMappings();
            services.AddAutoMapper(x => mapper.CreateMapper(), Assembly.Load("CatalystTest.BusinessHoliday.Application"));
        }
    }
}
