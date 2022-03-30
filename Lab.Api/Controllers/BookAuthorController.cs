using System;
using Bics;
using Microsoft.AspNetCore.Mvc;
using Lab.Models;
using Lab.Services;

namespace Lab.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BookAuthorController : Controller
	{
		private readonly IBookAuthorService _service;

		public BookAuthorController(IBookAuthorService service)
		{
			_service = service;
		}

		[HttpGet]
		public IMethodResult Search([FromQuery]BookAuthorSearchModel model)
		{
			return _service.Search<BookAuthorViewModel>(model);
		}

		[HttpGet("{id}")]
		public IMethodResult Single(int id)
		{
			return _service.Single<BookAuthorFormModel>(id);
		}

		[HttpGet("{id}/details")]
		public IMethodResult Details(int id)
		{
			return _service.Single<BookAuthorDetailModel>(id);
		}

		[HttpPost]
		public IMethodResult Add(BookAuthorFormModel model)
		{
			return _service.Add(model);
		}

		[HttpPut("{id}")]
		public IMethodResult Update(int id, BookAuthorFormModel model)
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
