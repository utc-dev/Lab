using Bics.Data.Entity;

namespace Lab.Data.Entity
{
    public class Bill : IEntity<int>
    {
        public int Id { get; set; }
        public string MaHD { get; set; }
        public string TenHD { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public string Note { get; set; }
    }
}
