using Bics.Models;
using System.Collections.Generic;
using Lab.Data.Entity;

namespace Lab.Models
{
	public class BookAuthorSearchModel : SearchModel
	{
		public override IList<string> TextSearchFields => new List<string> { nameof(BookAuthor.Address), nameof(BookAuthor.LoaiTacGia), nameof(BookAuthor.Mobile), nameof(BookAuthor.Ten) };	}
}
