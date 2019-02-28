using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoLopTinhTong
{
    class TinhTau
    {
        int soLuongKhach;
        string maDoanTau;

        public void nhapMaDoanTau()
        {
            Console.WriteLine("Nhap Ma Doan Tau: ");
            this.maDoanTau = Console.ReadLine();
            Console.WriteLine("Nhap So Luong Khach Hang: ");
            this.soLuongKhach = Convert.ToInt32(Console.ReadLine());
        }
        public float tinhTien()
        {
            float S = 0;

            if (this.soLuongKhach < 100)
            {
                S = this.soLuongKhach * 100000;
            }
            else
            {
                S = this.soLuongKhach * 80000;
            }
            return S;
        }

        public void inMatau()
        {
            Console.WriteLine(tinhTien());
            Console.WriteLine("in ra ma doan tau 2 lan");
            Console.WriteLine(this.maDoanTau);

            Console.WriteLine(this.maDoanTau);



        }
    }
}
