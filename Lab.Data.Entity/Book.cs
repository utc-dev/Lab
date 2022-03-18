using Bics.Data.Entity;

namespace Lab.Data.Entity
{
    public class Book : IEntity<int>
    {
        public int Id { get; set; }
        /// <summary>
        /// Tên sách
        /// </summary>
        public string Ten { get; set; }
        /// <summary>
        /// Loại sách
        /// </summary>
        public string Loai { get; set; }
        /// <summary>
        /// Tác giả
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Năm xuất bản
        /// </summary>
        public int PublishYear { get; set; }
        /// <summary>
        /// Số lượng
        /// </summary>
        public int SoLuong { get; set; }
    }
}
