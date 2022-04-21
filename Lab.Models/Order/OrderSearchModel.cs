using Bics.Models;
using System.Collections.Generic;
using Lab.Data.Entity;

namespace Lab.Models
{
	public class OrderSearchModel : SearchModel
	{
		public override IList<string> TextSearchFields => new List<string> { nameof(Order.Id), nameof(Order.TenDH), nameof(Order.MaDH), nameof(Order.OrderDate) };	}
}
