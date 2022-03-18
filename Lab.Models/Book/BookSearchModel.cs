using Bics.Models;
using System.Collections.Generic;
using Lab.Data.Entity;

namespace Lab.Models
{
	public class BookSearchModel : SearchModel
	{
		public override IList<string> TextSearchFields => new List<string> { nameof(Book.Author), nameof(Book.Loai), nameof(Book.Ten) };	}
}
