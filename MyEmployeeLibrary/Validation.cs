using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmployeeLibrary
{
    public class Validation
    {
        //Kiểm tra số nguyên
        public int CheckInt(int n)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    break;
                }
                Console.WriteLine("Vui nhập nhập số!");
            }
            return n;
        }

        //Kiểm tra số thực
        public double CheckDouble(double n)
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out n))
                {
                    break;
                }
                Console.WriteLine("Vui lòng nhập số!");
            }
            return n;
        }

        //Kiểm tra kiểu chuỗi
        public bool CheckString(string str)
        {
            int n;
            return int.TryParse(str, out n);
        }
    }
}
