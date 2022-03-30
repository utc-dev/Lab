using Bics.AutoMapper;
using Lab.Data.Entity;
using Lab.Models;

namespace Lab.AutoMapper
{
	class BookAuthorProfile : AutoMapperProfile
	{
		protected override void ConfigureMapping()
		{
			CreateMap<BookAuthor, BookAuthorViewModel>();
			CreateMap<BookAuthor, BookAuthorDetailModel>();
			CreateMap<BookAuthor, BookAuthorFormModel>().ReverseMap();
		}
	}
}
