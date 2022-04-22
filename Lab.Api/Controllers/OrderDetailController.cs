using System;
using Bics;
using Microsoft.AspNetCore.Mvc;
using Lab.Models;
using Lab.Services;

namespace Lab.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderDetailController : Controller
	{
		private readonly IOrderDetailService _service;

		public OrderDetailController(IOrderDetailService service)
		{
			_service = service;
		}

		[HttpGet]
		public IMethodResult Search([FromQuery]OrderDetailSearchModel model)
		{
			return _service.Search<OrderDetailViewModel>(model);
		}

		[HttpGet("{id}")]
		public IMethodResult Single(int id)
		{
			return _service.Single<OrderDetailFormModel>(id);
		}

		[HttpGet("{id}/details")]
		public IMethodResult Details(int id)
		{
			return _service.Single<OrderDetailDetailModel>(id);
		}

		[HttpPost]
		public IMethodResult Add(OrderDetailFormModel model)
		{
			return _service.Add(model);
		}

		[HttpPost("add-multiple")]
		public IMethodResult Add(List<OrderDetailFormModel> models)
		{
			return _service.Add(models: models);
		}

		[HttpPut("{id}")]
		public IMethodResult Update(int id, OrderDetailFormModel model)
		{
			model.Id = id;
			return _service.Update(model);
		}

		[HttpDelete("{id}")]
		public IMethodResult Remove(int id)
		{
			return _service.Remove(id);
		}
	}
}
