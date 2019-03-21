using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so sv:");
            n = Int32.Parse(Console.ReadLine());
            //tao mang doi tuong sv
            sinhvien[] sv = new sinhvien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = new sinhvien();
                sv[i].Nhap();
                sv[i].In();
            }
            //tim ra sv nao co diem tb thap nhat
            float min = sv[0].tinhTB();
            for (int i = 1; i < n; i++)
            {
                if (sv[i].tinhTB() < min) min = sv[i].tinhTB();

            }
            Console.WriteLine("SV diem thap nhat la: {0} ",min);
            //tim ra sv co chua chu 18i
            for (int i = 0; i < n; i++)
            {
                if (sv[i].maSV.Contains("IT"))
                    Console.WriteLine("SV ma {0} co diem tb la: {1} ", sv[i].maSV,sv[i].tinhTB());
            }
            //sap xep mang sv theo diem tb tang dan
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (sv[j].tinhTB() < sv[i].tinhTB())
                    {
                        sinhvien sxm;
                        sxm = sv[i];
                        sv[i] = sv[j];
                        sv[j] = sxm;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("sinh vien ma {0} co diem tb: {1}\n  ", sv[i].maSV,sv[i].tinhTB());
            }
            Console.ReadKey();

        }
    }
}
