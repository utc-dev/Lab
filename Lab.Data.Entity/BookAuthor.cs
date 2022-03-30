using Bics.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Data.Entity
{
    /// <summary>
    /// Danh sách tác giả của sách
    /// </summary>
    public class BookAuthor : IEntity<int>
    {
        public int Id { get; set; }
        /// <summary>
        /// Id Book
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// Tên tác giả
        /// </summary>
        public string Ten { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Loại tác giả (Tác giả chính, tác giả tham gia)
        /// </summary>
        public string LoaiTacGia { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string Mobile { get; set; }
    }
}
