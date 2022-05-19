using Bics.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Data.Entity
{
    public class OrderDetails : IEntity<int>
    {

        public string MaDH { get; set; }

        public string MaSP { get; set; }

        public int SoLuong { get; set; }

        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayTaoDon { get; set; }

        public string TrangThai { get; set; }

    }
}
