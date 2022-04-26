using Bics.AutoMapper;
using Lab.AutoMapper.Action;
using Lab.Data.Entity;
using Lab.Models;

namespace Lab.AutoMapper
{
	class BillProfile : AutoMapperProfile
	{
		protected override void ConfigureMapping()
		{
			CreateMap<Bill, BillViewModel>();
			CreateMap<Bill, BillDetailModel>();
			CreateMap<Bill, BillFormModel>()
				.ReverseMap();
			//.AfterMap<BookAction>();
		}
	}
}
