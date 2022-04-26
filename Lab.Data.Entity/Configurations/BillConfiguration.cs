using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab.Data.Entity
{
	class BillConfiguration : IEntityTypeConfiguration<Bill>
	{
		public void Configure(EntityTypeBuilder<Bill> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.MaHD).HasMaxLength(500).IsRequired().IsUnicode();
			builder.Property(x => x.MaSP).HasMaxLength(150).IsRequired(false).IsUnicode();
			builder.Property(x => x.TenHD).HasMaxLength(150).IsRequired(false).IsUnicode();
		}
	}
}
