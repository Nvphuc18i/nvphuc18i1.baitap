using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoLopTinhTong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1
            tinh_tong tong = new tinh_tong();
            tong.nhapn();
            tong.tinhTong();
            tong.inTong();
            tong.tinhTong2();
            tong.tinhTong3();
            tong.tongUoc();


            //Bài 2
            TinhTau tau= new TinhTau();
            tau.nhapMaDoanTau();
            tau.tinhTien();

            tau.inMatau();
            Console.ReadLine();

        }
    }
}
