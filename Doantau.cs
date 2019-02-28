using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Doantau
    {
        string matau;
        int soluong;
        public void nhap()
        {
            Console.WriteLine("Nhap ma tau : ");
            this.matau = Console.ReadLine();
            Console.WriteLine("Nhap so luong khach : ");
            this.soluong = int.Parse(Console.ReadLine());
        }
        public int tinhtien()
        {
            int tien;
            if (this.soluong < 100)
            {
                tien = this.soluong * 100000;
            }
            else
            {
                 tien = this.soluong * 80000;
            }
            return tien;
        }
        public void xuat()
        {
            Console.WriteLine("Ma tau {0} va tong tien la {1}", this.matau, tinhtien());
        }
    }
}
