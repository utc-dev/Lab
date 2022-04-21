using Bics.AutoMapper;
using Lab.Data.Entity;
using Lab.Models;

namespace Lab.AutoMapper
{
    public class OrderProfile : AutoMapperProfile
	{
		protected override void ConfigureMapping()
		{
			CreateMap<Order, OrderViewModel>();
			CreateMap<Order, OrderDetailModel>();
			CreateMap<Order, OrderFormModel>()
				.ReverseMap();
			//.AfterMap<BookAction>();
		}
	}
}
