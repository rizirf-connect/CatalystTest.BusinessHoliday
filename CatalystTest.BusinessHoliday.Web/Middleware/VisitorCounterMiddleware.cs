using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Web.Middleware
{
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public VisitorCounterMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path;
            var user = context.User;
            if (path.HasValue && path.Value == "/Holidays")
            {
                //context.Response.Cookies.Append("HolidayPageCount", pageCount.ToString(), new CookieOptions()
                //{
                //    Path = "/",
                //    HttpOnly = true,
                //    Secure = false,
                //});
            }
            await _requestDelegate(context);
        }
    }
}
