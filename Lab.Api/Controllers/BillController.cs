using System;
using Bics;
using Microsoft.AspNetCore.Mvc;
using Lab.Models;
using Lab.Services;

namespace Lab.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BillController : Controller
	{
		private readonly IBillService _service;

		public BillController(IBillService service)
		{
			_service = service;
		}

		[HttpGet]
		public IMethodResult Search([FromQuery]BillSearchModel model)
		{
			return _service.Search<BillViewModel>(model);
		}

		[HttpGet("{id}")]
		public IMethodResult Single(int id)
		{
			return _service.Single<BillFormModel>(id);
		}

		[HttpGet("{id}/details")]
		public IMethodResult Details(int id)
		{
			return _service.Single<BillDetailModel>(id);
		}

		[HttpPost]
		public IMethodResult Add(BillFormModel model)
		{
			return _service.Add(model);
		}

		[HttpPost("add-multiple")]
		public IMethodResult Add(List<BillFormModel> models)
		{
			return _service.Add(models: models);
		}

		[HttpPut("{id}")]
		public IMethodResult Update(int id, BillFormModel model)
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
