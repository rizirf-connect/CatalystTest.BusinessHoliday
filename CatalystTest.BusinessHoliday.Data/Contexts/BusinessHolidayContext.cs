using CatalystTest.BusinessHoliday.Data.Mappings;
using CatalystTest.BusinessHoliday.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Data.Contexts
{
    public class BusinessHolidayContext : IdentityDbContext
    {
        public DbSet<Holiday> Holidays { get; set; }

        public BusinessHolidayContext(DbContextOptions<BusinessHolidayContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new HolidayMap());
            base.OnModelCreating(builder);
        }
    }
}
