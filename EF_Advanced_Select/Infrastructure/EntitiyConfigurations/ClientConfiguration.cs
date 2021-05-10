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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(x => x.Name)
                   .HasColumnName("Name")
                   .HasMaxLength(200)
                   .HasColumnType("varchar");

            builder.Property(x => x.Address)
                   .HasColumnName("Address")
                   .HasMaxLength(200)
                   .HasColumnType("varchar");
        }
    }
}
