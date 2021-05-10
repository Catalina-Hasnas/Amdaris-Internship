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
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasMany(x => x.Products)
				   .WithOne(x => x.Category)
				   .HasForeignKey(x => x.CategoryId);
					

			builder.Property(x => x.Name)
				   .HasColumnType("varchar")
				   .IsRequired()
				   .HasMaxLength(200);

			
		}
	}
}
