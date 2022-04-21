using Bics.AutoMapper;
using Lab.AutoMapper.Action;
using Lab.Data.Entity;
using Lab.Models;

namespace Lab.AutoMapper
{
    class OrderDetailProfile : AutoMapperProfile
	{
		protected override void ConfigureMapping()
		{
			CreateMap<OrderDetails, OrderDetailViewModel>();
			CreateMap<OrderDetails, OrderDetailDetailModel>();
			CreateMap<OrderDetails, OrderDetailFormModel>()
				.ReverseMap();
			//.AfterMap<BookAction>();
		}
	}
}
