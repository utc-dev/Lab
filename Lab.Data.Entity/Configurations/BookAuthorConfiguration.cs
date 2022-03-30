using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab.Data.Entity
{
	class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
	{
		public void Configure(EntityTypeBuilder<BookAuthor> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Ten).HasMaxLength(150).IsRequired(false).IsUnicode();
			builder.Property(x => x.LoaiTacGia).HasMaxLength(50).IsRequired(false).IsUnicode();
			builder.Property(x => x.Address).HasMaxLength(500).IsRequired(false).IsUnicode();
			builder.Property(x => x.Mobile).HasMaxLength(500).IsRequired(false).IsUnicode();
		
		
		}
	}
}
