using Bics.Models;
using System.Collections.Generic;
using Lab.Data.Entity;

namespace Lab.Models
{
	public class BillSearchModel : SearchModel
	{
		public override IList<string> TextSearchFields => new List<string> { nameof(Bill.MaHD), nameof(Bill.MaSP), nameof(Bill.Note), nameof(Bill.TenHD) };	}
}
