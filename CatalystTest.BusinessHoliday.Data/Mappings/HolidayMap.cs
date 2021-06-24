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
        }
    }
}
