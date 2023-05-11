using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Rectangle
    {

        public int length, width;
        //public int Length
        //{
        //    get { return length; }
        //    set { length = value; }
        //}

        //public int Width
        //{
        //    get { return width; }
        //    set { width = value; }
        //}

        public void SetValue(int x, int y)
        {

            length = x;
            width = y;
        }





        public void ShowValue()
        {
            Console.WriteLine("Hinh chu nhat co chieu dai {0} va chieu rong {1}", length, width);
        }
    }



    public class Bai5
    {
        internal float pop40, pop50;
        internal string city;
        internal float Pop40
        {
            get { return pop40; }
            set { pop40 = value; }
        }

        internal float Pop50
        {
            get { return pop50; }
            set { pop50 = value; }
        }



        public void ShowValue()
        {
            Console.Write("{0,-20} {1,-5} {2,-15} {3,-5} {4,-15} {5,-15} ", city, "1940", pop40, "1950", pop50, Math.Round((pop50 - pop40) * 100 / pop40, 1).ToString() + "%");
            Console.WriteLine();
        }
    }

    
    














}



