using CatalystTest.BusinessHoliday.Data.Repositories;
using CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IHolidayRepository, HolidayRepository>();
        }
    }
}
