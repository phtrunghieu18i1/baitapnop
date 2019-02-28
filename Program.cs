using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinhtong sc = new Tinhtong();
            //sc.tong1();
            //sc.tong2();
            //sc.tong3();
            //sc.tong4();
            sc.Xuat();
            Doantau key = new Doantau();
            key.nhap();
            key.tinhtien();
            key.xuat();
            Console.ReadKey();
        }
    }
}
