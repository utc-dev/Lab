using System;
using System.Collections.Generic;
using Bics.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab.Data.Entity
{
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        public string MaDH { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }
        public string TenDH { get; set; }
    }
}
