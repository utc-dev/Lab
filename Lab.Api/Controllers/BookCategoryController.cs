using Bics;
using Lab.Models;
using Lab.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCategoryController : Controller
    {
		private readonly IBookCategoryService _service;

		public BookCategoryController(IBookCategoryService service)
		{
			_service = service;
		}

		[HttpGet]
		public IMethodResult Search([FromQuery]BookCategorySearchModel model)
		{
			return _service.Search<BookCategoryViewModel>(model);
		}

		[HttpGet("{id}")]
		public IMethodResult Single(int id)
		{
			return _service.Single<BookCategoryFormModel>(id);
		}

		[HttpGet("{id}/details")]
		public IMethodResult Details(int id)
		{
			return _service.Single<BookCategoryDetailModel>(id);
		}

		[HttpPost]
		public IMethodResult Add(BookCategoryFormModel model)
		{
			return _service.Add(model);
		}

		[HttpPut("{id}")]
		public IMethodResult Update(int id, BookCategoryFormModel model)
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
