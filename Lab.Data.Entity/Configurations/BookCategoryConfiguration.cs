using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Data.Entity.Configurations
{
    class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
	{
		public void Configure(EntityTypeBuilder<BookCategory> builder)
		{
			builder.HasKey(x => x.Id);

			builder.HasIndex(x => x.Ma).IsUnique();

			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Ma).HasMaxLength(50).IsRequired().IsUnicode();
			builder.Property(x => x.Ten).HasMaxLength(150).IsRequired(false).IsUnicode();
			builder.Property(x => x.CreatedBy).HasMaxLength(50).IsRequired(false).IsUnicode();
			builder.Property(x => x.LastModifiedBy).HasMaxLength(50).IsRequired(false).IsUnicode();
			builder.Property(x => x.DeletedBy).HasMaxLength(50).IsRequired(false).IsUnicode();

			// builder.ToTable("TheLoai", "Category"); // dbo.BookCategory => Category.TheLoai 
		}
	}
}
