using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmployeeLibrary
{
    public class NVQuanLy : NhanVien
    {
        public double HeSo { get; set; }
        //public NVQuanLy(int id, string ten, string diachi, GioiTinh gioitinh, double heso)
        //{
        //    this.ID = id;
        //    this.Ten = ten;
        //    this.DiaChi = diachi;
        //    this.GioiTinhs = gioitinh;
        //    this.HeSo = heso;
        //}
        
        //Ghi đè phương thức HienThi, Luong, Thuong
        public override string HienThi()
        {
            return base.HienThi();
        }

        public override double Luong()
        {
            double Luong = HeSo * 1450000;
            return Luong;
        }

        public override double Thuong()
        {
            return base.Thuong() + 500;
        }
    }
}
