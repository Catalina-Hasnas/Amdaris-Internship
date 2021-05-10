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
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>

    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {

            builder.Property(x => x.Quantity)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(x => x.UnitPrice)
                   .HasColumnType("decimal(8, 2)")
                   .IsRequired();

            builder.Property(x => x.ProductId)
                   .HasColumnType("int")
                   .IsRequired();

            builder.ToTable("OrderItems");
        }
    }
}
