using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab.Data.Entity
{
	class BookConfiguration : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Ten).HasMaxLength(500).IsRequired(false).IsUnicode();
			builder.Property(x => x.Loai).HasMaxLength(150).IsRequired(false).IsUnicode();
			builder.Property(x => x.Author).HasMaxLength(150).IsRequired(false).IsUnicode();
		
		}
	}
}
