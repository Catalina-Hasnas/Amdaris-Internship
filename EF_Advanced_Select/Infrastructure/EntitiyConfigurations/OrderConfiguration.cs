using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiyConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.HasMany(x => x.OrderItems)
                   .WithOne(x => x.Order)
                   .HasForeignKey(x => x.OrderId);

            builder.HasOne(x => x.Client)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.ClientId)
                   .IsRequired();

            builder.Property(x => x.CreatedAt)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(x => x.TotalPrice)
                   .HasColumnType("decimal(8, 2)")
                   .IsRequired();

            builder.ToTable("Orders");
        }
    }
}

