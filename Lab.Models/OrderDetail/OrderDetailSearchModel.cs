using Bics.Models;
using System.Collections.Generic;
using Lab.Data.Entity;

namespace Lab.Models
{
	public class OrderDetailSearchModel : SearchModel
	{
		public override IList<string> TextSearchFields => new List<string> { nameof(OrderDetails.MaDH), nameof(OrderDetails.MaSP), nameof(OrderDetails.SoLuong) };	}
}
