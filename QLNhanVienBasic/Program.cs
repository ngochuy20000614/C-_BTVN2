using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEmployeeLibrary;

namespace QLNhanVienBasic
{
    public class Program
    {
        public static Validation validation;
        public static EmployeeManagement employee;
        public static List<NhanVien> nhanviens;


        //Thiết kế menu cho người dùng
        public static void Menu()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Bạn muốn chọn option nào ?");
            Console.WriteLine("1.Thêm nhân viên");
            Console.WriteLine("2.Chỉnh sửa nhân viên");
            Console.WriteLine("3.Xóa nhân viên");
            Console.WriteLine("4.Hiển thị danh sách sinh viên");
            Console.WriteLine("5.Thoát");
            Console.WriteLine("------------------------");
        }

        //Xây dựng hàm lựa chọn cho người dùng
        public static void Choice(int number)
        {
            switch (number)
            {
                case 1:
                    //Thêm nhân viên
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        employee.Add();
                    }
                    break;
                case 2:
                    //Sửa nhân viên
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.Write("Nhập ID nhân viên muốn chỉnh sửa: ");
                        int id = validation.CheckInt(0);
                        employee.Update(id);
                    }
                    break;
                case 3:
                    //Xóa nhân viên
                    {
                        employee.Delete();
                    }
                    break;
                case 4:
                    //Hiện thị danh sách nhân viên
                    {
                        employee.Display();
                    }
                    break;
            }
        }
        
        //void main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            employee = new EmployeeManagement();
            NVQuanLy nVQuanLy1 = new NVQuanLy { ID = 1, Ten = "Ngọc Huy", DiaChi = "48 Cao Thắng", GioiTinhs = GioiTinh.Nam, HeSo = 3 };
            NVBanHang nVBanHang1 = new NVBanHang { ID = 2, Ten = "Võ Lập", DiaChi = "48 Cao thắng", GioiTinhs = GioiTinh.Nam, SoSanPham = 100 };
            NVBanHang nVBanHang2 = new NVBanHang { ID = 3, Ten = "Minh Hiếu", DiaChi = "48 Cao thắng", GioiTinhs = GioiTinh.Nam, SoSanPham = 50 };
            employee.ListNhanViens.Add(nVQuanLy1);
            employee.ListNhanViens.Add(nVBanHang1);
            employee.ListNhanViens.Add(nVBanHang2);
            validation = new Validation();
            int choice, a = 0;

            //nếu lựa chọn = 5 thì sẽ kết thúc vòng lập và đưa ra màn hình kết quả "Đã thoát"
            while (a < 5)
            {
                Menu();
                choice = validation.CheckInt(0);
                a = choice;
                if (a == 5)
                    Console.WriteLine("Đã thoát!");
                Choice(choice);
            }
            Console.ReadLine();
        }
    }
}
