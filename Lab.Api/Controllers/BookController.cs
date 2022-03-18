using System;
using Bics;
using Microsoft.AspNetCore.Mvc;
using Lab.Models;
using Lab.Services;

namespace Lab.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BookController : Controller
	{
		private readonly IBookService _service;

		public BookController(IBookService service)
		{
			_service = service;
		}

		[HttpGet]
		public IMethodResult Search([FromQuery]BookSearchModel model)
		{
			return _service.Search<BookViewModel>(model);
		}

		[HttpGet("{id}")]
		public IMethodResult Single(int id)
		{
			return _service.Single<BookFormModel>(id);
		}

		[HttpGet("{id}/details")]
		public IMethodResult Details(int id)
		{
			return _service.Single<BookDetailModel>(id);
		}

		[HttpPost]
		public IMethodResult Add(BookFormModel model)
		{
			return _service.Add(model);
		}

		[HttpPut("{id}")]
		public IMethodResult Update(int id, BookFormModel model)
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
