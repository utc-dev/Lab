using Bics.AutoMapper;
using Lab.Data.Entity;
using Lab.Models;

namespace Lab.AutoMapper
{
    internal class BookCategoryProfile : AutoMapperProfile
    {
        protected override void ConfigureMapping()
        {
            CreateMap<BookCategory, BookCategoryViewModel>();
            CreateMap<BookCategory, BookCategoryDetailModel>();
            CreateMap<BookCategory, BookCategoryFormModel>().ReverseMap();
        }
    }
}
