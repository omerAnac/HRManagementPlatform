﻿using HRManagement.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DAL.Concrete.Context.EntityTypeConfiguration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Address)
                 .HasMaxLength(100)
                 .IsRequired();

            builder.Property(a => a.RegisterDate)
                .IsRequired()
                .HasColumnType("Date");

            builder.Property(a => a.PhoneNumber)
                .HasMaxLength(12);

            builder.Property(a => a.CompanyName)
             .HasMaxLength(100)
             .IsRequired();

            builder.Property(a => a.CompanyType)
             .IsRequired();

            builder.Property(a => a.ImageUrl);
            ;
            builder.Property(a => a.MailExtension);

            builder.Property(a => a.TaxId)
                .IsRequired();






        }
    }
}
