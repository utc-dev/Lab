using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Data.Entity
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
	{
		public void Configure(EntityTypeBuilder<OrderDetails> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.MaSP).HasMaxLength(500).IsRequired(true).IsUnicode();
			builder.Property(x => x.MaDH).HasMaxLength(150).IsRequired(true).IsUnicode();
			builder.Property(x => x.SoLuong).IsRequired(true);
			builder.Property(x => x.NgayTaoDon).HasColumnType("date");
			builder.Property(x => x.TrangThai).HasMaxLength(500).IsRequired(true).IsUnicode();
		}

    }
}
