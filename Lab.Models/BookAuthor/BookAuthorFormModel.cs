namespace Lab.Models
{
	public class BookAuthorFormModel
	{
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Ten { get; set; }
        public DateTime Birthday { get; set; }
        public string LoaiTacGia { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}
