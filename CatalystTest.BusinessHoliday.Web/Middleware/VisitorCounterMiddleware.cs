using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Web.Middleware
{
    public class VisitorCounterMiddleware
    {
        private const string SESSION_KEY = "PageCount";
        private const string HOLIDAY_PATH = "/Holidays";
        private readonly RequestDelegate _requestDelegate;

        public VisitorCounterMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path;
            if (path.HasValue && path.Value == HOLIDAY_PATH)
            {
                if (!context.Session.Keys.Contains(SESSION_KEY))
                {
                    context.Session.SetInt32(SESSION_KEY, 1);
                }
                else
                {
                    var prevValue = context.Session.GetInt32(SESSION_KEY).Value;
                    context.Session.SetInt32(SESSION_KEY, prevValue + 1);
                }
            }
            await _requestDelegate(context);
        }
    }
}
