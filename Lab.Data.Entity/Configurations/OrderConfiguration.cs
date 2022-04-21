using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Data.Entity
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.MaDH).HasMaxLength(500).IsRequired(true).IsUnicode();
			builder.Property(x => x.TenDH).HasMaxLength(150).IsRequired(true).IsUnicode();
			builder.Property(x => x.OrderDate).IsRequired(true);

		}

	}
}
