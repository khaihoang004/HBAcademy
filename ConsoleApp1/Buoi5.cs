using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Buoi5
    {
        public struct HocVien
        {
            public string name;
            public int diem;
        }
        public static int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }


        public static int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }

        public static int PTTSNT(int a)
        {
            int i = 2;
            while (a > 1)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    a = a / i;
                }
                else
                {
                    i++;
                }
            }
            return 1;
        }

    }
}
