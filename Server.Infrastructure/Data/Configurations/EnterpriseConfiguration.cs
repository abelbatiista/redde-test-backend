using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastructure.Data.Configurations
{
    public class EnterpriseConfiguration : IEntityTypeConfiguration<Enterprise>
    {
        public void Configure(EntityTypeBuilder<Enterprise> builder)
        {
            builder.ToTable("enterprise");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Activity).HasColumnName("activity");

            builder.Property(e => e.Branch).HasColumnName("branch");

            builder.Property(e => e.Category).HasColumnName("category");

            builder.Property(e => e.Comercial).HasColumnName("comercial");

            builder.Property(e => e.Name).HasColumnName("name");

            builder.Property(e => e.Payment).HasColumnName("payment");

            builder.Property(e => e.Rnc).HasColumnName("rnc");

            builder.Property(e => e.Status).HasColumnName("status");
        }
    }
}
