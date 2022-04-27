using Bics;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lab.Services
{
	class Bootstrap : IBootstrap
	{
		public int Priority => 1000;

		public void Configure(IApplicationBuilder app)
		{
		}

		public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IBookService, BookService>();
			services.AddScoped<IBookAuthorService, BookAuthorService>();
			services.AddScoped<IBookCategoryService, BookCategoryService>();
			services.AddScoped<IOrderService, OrderService>();
			services.AddScoped<IOrderDetailService, OrderDetailService>();
			services.AddScoped<IBillService, BillService>();
		}
	}
}
