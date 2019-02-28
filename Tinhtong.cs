using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Tinhtong
    {
        public int tong1()
        {
            int n1,S1=0;
            Console.WriteLine("Nhap n1 : ");
            n1 = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n1; i++)
            {
                if (i % 2 == 1)
                {
                    S1 = S1 + i;
                }
                else
                {
                    S1 = S1 - i;
                }
            }
            return S1;
        }
        public int tong2()
        {
            int n2, S2 = 0;
            Console.WriteLine("Nhap n2 : ");
            n2 = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n2; i++)
            {
                S2 = S2 + 1 / i;
            }
            return S2;
        }
        public int tong3()
        {
            int n3, S3 = 0;
            Console.WriteLine("Nhap n3 : ");
            n3 = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n3; i++)
            {
                S3 = S3 + i; 
            }
            return S3;
        }
        public int tong4()
        {
            int n4, S4 = 0;
            Console.WriteLine("Nhap n4 : ");
            n4 = int.Parse(Console.ReadLine());
            for(int i=1;i<= Math.Sqrt(n4); i++)
            {
                if(n4 % i == 0)
                {
                    int j = n4 / i;
                    if(i == j)
                    {
                        S4 = S4 + i;                  
                    }
                    else
                    {
                        S4 = S4 + i + j;

                    }

                }
            }
            return S4;
        }
        public void Xuat()
        {
            Console.WriteLine("Cac Tong lan luot la :S1 = {0},S2 = {1},S3 = {2}, S4 = {3}", tong1(), tong2(),tong3(),tong4());

        }
    }
}
