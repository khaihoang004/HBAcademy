using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBAcademy
{
    internal class Buoi7
    {
        public struct NguoiDung
        {
            public string HoTen, TenDangNhap, Matkhau, Email,SoDienThoai;
            
        }

        public static void Thuchanh()
        {
            Console.WriteLine("Nhap chuoi vao: ");
            string input = Console.ReadLine();
            string a1 = input;
            string a2 = input;
            int Uppercount = 0;
            int Lowercount = 0;
            int Digitcount = 0;
            int k = input.Length;

            Console.Write("------------------------------------------------------------------------\n");
            for (int i = 0; i < k; i++)
            {
                string b = a1.Substring(0, 1);
                a1 = a1.Substring(1);
                char c = char.Parse(b);
                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        Uppercount++;
                    }
                    else
                    {
                        Lowercount++;
                    }
                }
                else if (char.IsDigit(c))
                {
                    Digitcount++;
                }
            }

            if (Uppercount > 0)
            {
                Console.WriteLine("Day ky tu co chu hoa");
            }

            if (Lowercount > 0)
            {
                Console.WriteLine("Day ky tu co chu thuong");
            }

            if (Digitcount > 0)
            {
                Console.WriteLine("Day ky tu co so");
            }






            Console.WriteLine("------------------");
            Console.WriteLine("Ky tu can kiem tra: ");
            string n = Console.ReadLine();
            for (int i = 0; i < k; i++)
            {
                string b = a2.Substring(0, 1);
                a2 = a2.Substring(1);

                if (b == n)
                {
                    Console.WriteLine("Day ky tu co ky tu {0}", n);
                }
                break;
            }



            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Heheh");
            Console.WriteLine(stringBuilder);
        }
        internal static void BTVN()
        {
            ////BTVN
            Console.WriteLine("Nhap chuoi vao: ");
            string input = Console.ReadLine();
            string a1 = input;
            string a2 = input;
            int Uppercount = 0;
            int Lowercount = 0;
            int Digitcount = 0;
            int k = input.Length;

            Console.Write("------------------------------------------------------------------------\n");
            for (int i = 0; i < k; i++)
            {
                string b = a1.Substring(0, 1);
                a1 = a1.Substring(1);
                char c = char.Parse(b);
                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        Uppercount++;
                    }
                    else
                    {
                        Lowercount++;
                    }
                }
                else if (char.IsDigit(c))
                {
                    Digitcount++;
                }
            }

            if (Uppercount > 0)
            {
                Console.WriteLine("Day ky tu co chu hoa");
            }

            if (Lowercount > 0)
            {
                Console.WriteLine("Day ky tu co chu thuong");
            }

            if (Digitcount > 0)
            {
                Console.WriteLine("Day ky tu co so");
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Ky tu can kiem tra: ");
            string n = Console.ReadLine();
            for (int i = 0; i < k; i++)
            {
                string b = a2.Substring(0, 1);
                a2 = a2.Substring(1);

                if (b == n)
                {
                    Console.WriteLine("Day ky tu co ky tu {0}", n);
                }
                break;
            }

            //Console.WriteLine("Nhap chuoi ky tu s:");
            //string s = Console.ReadLine();

            //int dem2 = 0;
            //int n = 0;
            //int n0 = 0;
            //int i = 0;


            //bool m = input.Contains(s);
            //if (m == true)
            //{
            //    Console.WriteLine("Trong str chua s");
            //}
            //else
            //{
            //    Console.WriteLine("Trong str khong chua s");
            //}









            //while (i < (input.Length) / 2)
            //{
            //    if (input[i] != input[input.Length - i - 1])
            //    {
            //        n0 = 1;
            //        break;
            //    }
            //    i++;
            //}
            //if (n0 == 0)
            //{
            //    Console.WriteLine("str co tinh doi xung");
            //}
            //else
            //{
            //    Console.WriteLine("str khong co tinh doi xung");
            //}

            //string n1 = input;
            //string[] tu = n1.Split(new char[] { });
            //int n2 = 0;
            //for (i = 0; i < tu.Length; i++)
            //{
            //    n2++;

            //}
            //Console.WriteLine(n2);

            //string n3 = input.Trim();

            ////for (i = 0; i < tu.Length; i++)
            ////{
            ////    tu[i][0].IsUpper;
            ////}

            //Console.Write("Nhap vao ky tu can dem: ");
            //char n5 = Convert.ToChar(Console.ReadLine());
            //string n6 = input;
            //int n7 = input.Length;
            //int count = 0;
            //for (int i = 0; i < n7; i++)
            //{
            //    if (n6[i] == n5)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Ky tu {n5} xuat hien {count} lan");



            //StringBuilder sb = new StringBuilder();

            //sb.Append("yahooo");
            //sb.Clear();
            //sb.AppendFormat("01234567Weeeeeeeeeeeeeeeeee");
            //sb.Insert(8, "haaaaaa//");
            //sb.Remove(3, 3);
            //sb.Replace('a', 'e');
        }








    }
}
