using Bics.AutoMapper;
using Lab.Data.Entity;
using Lab.Models;

namespace Lab.AutoMapper
{
	class BookProfile : AutoMapperProfile
	{
		protected override void ConfigureMapping()
		{
			CreateMap<Book, BookViewModel>();
			CreateMap<Book, BookDetailModel>();
			CreateMap<Book, BookFormModel>().ReverseMap();
		}
	}
}
