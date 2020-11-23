using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhakho
{
    class Xuatkho
    {
        public int IdHoaDon { get; set; }
        public string  MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public string Loai { get; set; }
        public string DonVi { get; set; }
  
        public int SDTs { get; set; }
        public string TenKhachHang { get; set; }
        public int ThanhToan {
            get {
                return DonGia * SoLuong;
                }
            }

    }
}
