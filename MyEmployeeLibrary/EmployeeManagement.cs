using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmployeeLibrary
{
    public class EmployeeManagement
    {
        public List<NhanVien> ListNhanViens { get; set; }
        Validation Validation = new Validation();

        public EmployeeManagement()
        {
            ListNhanViens = new List<NhanVien>();
        }

        public void Add()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            Console.WriteLine("Mời bạn chọn loại nhân viên muốn thêm: ");
            Console.WriteLine("1. Nhân viên quản lý ");
            Console.WriteLine("2. Nhân viên bán hàng");
            choice = Validation.CheckInt(0);
            if(choice == 1)
            {
                nhaplai:
                Console.Write("ID: ");
                int id = Validation.CheckInt(0);
                foreach (var nv in ListNhanViens)
                {
                    if (nv.ID == id)
                    {
                        Console.WriteLine("ID này đã tồn tại, vui lòng nhập lại: ");
                        goto nhaplai;
                    }
                }
                Console.Write("Tên: ");
                string ten = Console.ReadLine();
                while (Validation.CheckString(ten))
                {
                    Console.Write("Vui lòng nhập lại tên");
                    ten = Console.ReadLine();
                }
                Console.Write("Địa chỉ: ");
                string diachi = Console.ReadLine();
                while (Validation.CheckString(ten))
                {
                    Console.Write("Vui lòng nhập lại địa chỉ");
                    diachi = Console.ReadLine();
                }
                Console.Write("Giới tính Nam(1)/Nữ(0): ");
                int luachon = Validation.CheckInt(0);
                Console.Write("Hệ số: ");
                double heso = Validation.CheckDouble(0);               
                if(luachon == 1)
                {
                    NVQuanLy ql1 = new NVQuanLy() { ID = id, Ten = ten, DiaChi = diachi, GioiTinhs = GioiTinh.Nam, HeSo = heso };
                    ListNhanViens.Add(ql1);
                    Console.WriteLine("Thêm thành công");
                    Display();
                }
                else
                {
                    NVQuanLy ql1 = new NVQuanLy() { ID = id, Ten = ten, DiaChi = diachi, GioiTinhs = GioiTinh.Nữ, HeSo = heso };
                    ListNhanViens.Add(ql1);
                    Console.WriteLine("Thêm thành công");
                    Display();
                }
            }
            else
            {
                nhaplai:
                Console.Write("ID: ");
                int id = Validation.CheckInt(0);
                foreach (var nv in ListNhanViens)
                {
                    if (nv.ID == id)
                    {
                        Console.Write("ID này đã tồn tại, vui lòng nhập lại: ");
                        goto nhaplai;
                    }
                }
                Console.Write("Tên: ");
                string ten = Console.ReadLine();
                while (Validation.CheckString(ten))
                {
                    Console.Write("Vui lòng nhập lại tên");
                    ten = Console.ReadLine();
                }
                Console.Write("Địa chỉ: ");
                string diachi = Console.ReadLine();
                while (Validation.CheckString(ten))
                {
                    Console.Write("Vui lòng nhập lại địa chỉ");
                    diachi = Console.ReadLine();
                }
                Console.Write("Giới tính Nam(1)/Nữ(0): ");
                int luachon = Validation.CheckInt(0);
                Console.Write("Số sản phẩm bán được: ");
                int sosanpham = Validation.CheckInt(0);
                if (luachon == 1)
                {
                    NVBanHang bh1 = new NVBanHang() { ID = id, Ten = ten, DiaChi = diachi, GioiTinhs = GioiTinh.Nam, SoSanPham = sosanpham };
                    ListNhanViens.Add(bh1);
                    Console.WriteLine("Thêm thành công");
                    Display();
                }
                else
                {
                    NVBanHang bh1 = new NVBanHang() { ID = id, Ten = ten, DiaChi = diachi, GioiTinhs = GioiTinh.Nữ, SoSanPham = sosanpham };
                    ListNhanViens.Add(bh1);
                    Console.WriteLine("Thêm thành công");
                    Display();
                }
            }            
        }

        //Cập nhật nhân viên
        public void Update(int ID)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (ListNhanViens.Count > 0)
            {
                foreach (NhanVien nv in ListNhanViens)
                {
                    if (nv.ID == ID)
                    {
                        Console.Write("Tên: ");
                        string ten = Console.ReadLine();
                        while (Validation.CheckString(ten))
                        {
                            Console.WriteLine("Vui lòng nhập lại tên nhân viên");
                            ten = Console.ReadLine();
                        }
                        Console.Write("Địa chỉ: ");
                        string diachi = Console.ReadLine();
                        while (Validation.CheckString(diachi))
                        {
                            Console.WriteLine("Vui lòng nhập lại tên nhân viên");
                            diachi = Console.ReadLine();
                        }
                        Console.Write("Giới tính Nam(1)/Nữ(0): ");
                        int luachon = Validation.CheckInt(0);
                        if(luachon == 1)
                        {
                            Console.WriteLine("Bạn thật sự muốn cập nhật nhân viên này: Yes(1)/No(0)");
                            int luaChon;
                            luaChon = Validation.CheckInt(0);
                            if (luaChon == 1)
                            {
                                nv.Ten = ten;
                                nv.DiaChi = diachi;
                                nv.GioiTinhs = GioiTinh.Nam;
                                Console.WriteLine("Chỉnh sửa thành công");
                                Display();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bạn thật sự muốn cập nhật nhân viên này: Yes(1)/No(0)");
                            int luaChon;
                            luaChon = Validation.CheckInt(0);
                            if (luaChon == 1)
                            {
                                nv.Ten = ten;
                                nv.DiaChi = diachi;
                                nv.GioiTinhs = GioiTinh.Nữ;
                                Console.WriteLine("Chỉnh sửa thành công");
                                Display();
                                break;
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Không tồn tại nhân viên có ID này");break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Không tồn tại nhân viên có ID này");
            }
        }

        //Xóa một nhân viên
        public void Delete()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập ID nhân viên muốn xóa: ");
            int count = ListNhanViens.Count;
            int dem = 0;
            int id = Validation.CheckInt(0);
            if (ListNhanViens.Count > 0)
            {
                foreach (NhanVien nv in ListNhanViens)
                {
                    dem = dem + 1;
                    if (nv.ID == id)
                    {
                        Console.WriteLine("Bạn thật sự muốn xóa nhân viên này Yes(1)/No(0): ");
                        int luaChon;
                        luaChon = Validation.CheckInt(0);
                        if (luaChon==1)
                        {
                            ListNhanViens.Remove(nv);
                            Console.WriteLine("Xóa thành công");break;
                            
                        }
                        else
                        {
                            Console.WriteLine("Xóa thất bại");break;
                        }
                    }else if(dem == count)
                    {
                        Console.WriteLine("Không tồn tại ID này");break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Danh sách đang rỗng");
            }
        }

        //Hiển thị danh sách nhân viên
        public void Display()
        {
            if (ListNhanViens.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
            }
            else
            {
                Console.WriteLine("\tDANH SÁCH NHÂN VIÊN");

                Console.WriteLine("\tID\tTên\t     Giới tính\t        Địa chỉ\t        Lương\tThưởng");
                foreach (var nhanVien in ListNhanViens)
                {
                    Console.WriteLine("\t{0}\t{1,-10}\t{2,-10}\t{3,-10}\t{4,-7}\t{5}", nhanVien.ID, nhanVien.Ten, nhanVien.GioiTinhs,nhanVien.DiaChi,nhanVien.Luong(),nhanVien.Thuong());
                }
            }
        }
    }
}
