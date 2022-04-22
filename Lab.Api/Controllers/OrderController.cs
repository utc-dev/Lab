using System;
using Bics;
using Microsoft.AspNetCore.Mvc;
using Lab.Models;
using Lab.Services;

namespace Lab.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
		public OrderController(IOrderService service)
		{
			_service = service;
		}

		[HttpGet]
		public IMethodResult Search([FromQuery]OrderSearchModel model)
		{
			return _service.Search<OrderViewModel>(model);
		}

		[HttpGet("{id}")]
		public IMethodResult Single(int id)
		{
			return _service.Single<OrderFormModel>(id);
		}

		[HttpGet("{id}/details")]
		public IMethodResult Details(int id)
		{
			return _service.Single<OrderDetailModel>(id);
		}

		[HttpPost]
		public IMethodResult Add(OrderFormModel model)
		{
			return _service.Add(model);
		}

		[HttpPut("{id}")]
		public IMethodResult Update(int id, OrderFormModel model)
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
