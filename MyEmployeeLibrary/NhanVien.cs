using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmployeeLibrary
{
    public enum GioiTinh
    {
        Nam, Nữ
    }
    public class NhanVien
    {
        //Automatic properties
        public int ID { get; set; }

        public string Ten { get; set; }

        public string DiaChi { get; set; }

        public GioiTinh GioiTinhs { get; set; }

        //Hiển thị thông tin nhân viên
        public virtual string HienThi()
        {
            return "ID: " + ID + " Ten: " + Ten + " DiaChi: " + DiaChi + " GioiTinh: " + GioiTinhs;
        }

        //Tính lương nhân viên
        public virtual double Luong()
        {
            return 1;
        }

        //Thưởng cho nhân viên
        public virtual double Thuong()
        {
            return 1000;
        }
    }
}
