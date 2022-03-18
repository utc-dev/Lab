using System;
using Bics.Services;
using Lab.Data.Entity;

namespace Lab.Services
{
	public interface IBookService : IService<Book, int>
	{
	}
}
