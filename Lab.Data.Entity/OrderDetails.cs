using Bics.Data.Entity;
using System;
using System.Collections.Generic;
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
    }
}
