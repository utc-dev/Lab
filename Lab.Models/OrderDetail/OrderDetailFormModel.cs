using System;

namespace Lab.Models
{
	public class OrderDetailFormModel
	{
		public string MaDH { get; set; }
		public string MaSP { get; set; }
		public int SoLuong { get; set; }
		public int Id { get; set; }
		public DateTime NgayTaoDon { get; set; }
		public string TrangThai { get; set; }
	}
}
