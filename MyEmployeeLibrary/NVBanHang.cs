using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmployeeLibrary
{
    public class NVBanHang : NhanVien
    {
        public int SoSanPham { get; set; }

        //public NVBanHang(int id, string ten, string diachi, GioiTinh gioitinh, int sosanpham)
        //{
        //    this.ID = id;
        //    this.Ten = ten;
        //    this.DiaChi = diachi;
        //    this.GioiTinhs = gioitinh;
        //    this.SoSanPham = sosanpham;
        //}
        //Ghi đè phương thức HienThi và Luong
        public override string HienThi()
        {
            return base.HienThi();
        }

        public override double Luong()
        {
            double luong = SoSanPham * 5000;
            return luong;
        }
    }
}
