using CatalystTest.BusinessHoliday.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Data.Mappings
{
    public class HolidayMap : IEntityTypeConfiguration<Holiday>
    {
        public void Configure(EntityTypeBuilder<Holiday> builder)
        {
            builder.ToTable("BusinessHoliday");

            builder.Property(h => h.Id)
                .HasColumnName("BusinessHolidayId")
                .IsRequired();

            builder.Property(h => h.HolidayOccasion)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(h => h.FromDate)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(h => h.ToDate)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(h => h.Active)
                .HasDefaultValue(false)
                .IsRequired();

            builder.HasData(
                new Holiday(Guid.NewGuid(), "EidUlAzha", DateTime.Now.AddDays(1), DateTime.Now.AddDays(3), true),
                new Holiday(Guid.NewGuid(), "Eid", DateTime.Now.AddDays(5), DateTime.Now.AddDays(8), true),
                new Holiday(Guid.NewGuid(), "Moharram", DateTime.Now.AddDays(10), DateTime.Now.AddDays(11), true),
                new Holiday(Guid.NewGuid(), "Iqbal", DateTime.Now.AddDays(15), DateTime.Now.AddDays(15), true),
                new Holiday(Guid.NewGuid(), "Christmas", DateTime.Now.AddDays(20), DateTime.Now.AddDays(20), false)
                );
        }
    }
}
