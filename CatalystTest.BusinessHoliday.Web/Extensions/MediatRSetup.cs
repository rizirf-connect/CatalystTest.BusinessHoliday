using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Web.Extensions
{
    public static class MediatRSetup
    {
        public static void AddMediatRSetup(this IServiceCollection services) =>
            services.AddMediatR(Assembly.Load("CatalystTest.BusinessHoliday.Domain"));
    }
}
