using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBAcademy
{
    internal class Buoi10
    {
        internal static void Thuchanh1()
        {
            Console.WriteLine("So so muon so sanh :"); int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] ints = new int[n];
            Console.WriteLine("Danh sach cac so:");
            for (int i = 0; i < n; i++)
            {
                ints[i] = random.Next(0, 12);
                Console.WriteLine(ints[i]);
            }

            int max = ints[0];
            int min = ints[0];
            int average = ints[0];
            Console.WriteLine(ints.Length);
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > max)
                {

                    max = ints[i];

                }
            }





            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < min)
                {
                    min = ints[i];
                }
            }

            average = ints.Sum() / ints.Length;

            Queue<int> Max = new Queue<int>();
            Queue<int> Min = new Queue<int>();
            Queue<int> Average = new Queue<int>();

            {
                int i = 0;
                for (i = 0; i < ints.Length; i++)
                {
                    if (ints[i] == max)
                    {
                        Max.Enqueue(i);
                    }
                    if (ints[i] == min)
                    {
                        Min.Enqueue(i);
                    }
                    if (ints[i] == average)
                    {
                        Average.Enqueue(i);
                    }
                }
            }
            Console.Clear();
            Console.WriteLine(" - Vi tri cac so dat gia tri max la: ");
            while (Max.Count > 0)
            {
                Console.Write(Max.Dequeue() + "  ");
                if (Max.Count > 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\n - Vi tri cac so dat gia tri min la: ");
            while (Min.Count > 0)
            {
                Console.Write(Min.Dequeue() + "  ");
                if (Min.Count > 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\n - Vi tri cac so dat gia tri trung binh la: ");
            while (Average.Count > 0)
            {
                Console.Write(Average.Dequeue() + "  ");
                if (Average.Count > 1)
                {
                    Console.Write(", ");
                }
            }
        }
        internal static void Thuchanh2()
        {
            List<string> ten = new List<string>();
            List<int> diem = new List<int>();

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap ten hoc vien");
                ten[i]  = Console.ReadLine();
                Console.WriteLine("");
                diem[i] = int.Parse(Console.ReadLine());
            }
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n;i++)
            {
                if (diem[i] > 8)
                {
                    queue.Enqueue(i);
                }
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Danh sach sinh vien duoc diem Toan tren 8 diem:");
            while (queue.Count > 0)
            {
                Console.WriteLine(ten[queue.Dequeue()]);
            }
        }
        internal static void Thuchanh3()
        {
            Random random = new Random();
            Console.Clear();
            //Danh sach
            string[] ten = new string[] { "Bac", "Nam", "Thong", "Nhat", "Yahoooo" };
            string[] hang = new string[] { "Bun dau", "Nem nuong", "Pho cuon", "Banh mi chao", "Tra da" };



            //Gia tien cac mon hang
            int[] giatien = new int[hang.Length];
            for (int j = 0; j < giatien.GetLength(0); j++)
            {
                giatien[j] = random.Next(1, 10) * 1000;
            }




            int[,] Soluong = new int[ten.Length, hang.Length];
            for (int i = 0; i < Soluong.GetLength(0); i++)
            {
                for (int j = 0; j < Soluong.GetLength(1); j++)
                {
                    Soluong[i, j] = random.Next(1, 10);  //So luong moi mon do
                }

            }

            //Hien thi bang ra ngoai man hinh
            Console.Write($"{"",-15}");
            for (int i = 0; i < hang.GetLength(0); i++)
            {
                Console.Write($"{hang[i],-15}");

            }
            Console.WriteLine();
            for (int i = 0; i < Soluong.GetLength(0); i++)
            {
                Console.Write($"{ten[i],-15}");
                for (int j = 0; j < Soluong.GetLength(1); j++)
                {
                    Console.Write($"{Soluong[i, j],-15}");

                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------");


            //So luong moi nhan vien ban duoc
            int[] soluong_nv = new int[hang.Length];
            for (int i = 0; i < soluong_nv.GetLength(0); i++)
            {
                soluong_nv[i] = 0;
            }

            for (int i = 0; i < soluong_nv.GetLength(0); i++)
            {
                for (int j = 0; j < Soluong.GetLength(1); j++)
                {
                    soluong_nv[i] += Soluong[i, j];
                }
            }

            //Doanh thu cua moi nhan vien
            int[] doanhthu_nv = new int[ten.Length];
            for (int i = 0; i < doanhthu_nv.GetLength(0); i++)
            {
                doanhthu_nv[i] = 0;
            }

            for (int i = 0; i < Soluong.GetLength(0); i++)
            {
                for (int j = 0; j < Soluong.GetLength(1); j++)
                {
                    doanhthu_nv[i] += Soluong[i, j] * giatien[j];

                }
                //Console.WriteLine($"Doanh thu cua {ten[i]} la: {doanhthu_nv[i]}");
            }

            //Tong so luong moi mon hang
            int[] Tongsoluong = new int[hang.Length];
            for (int i = 0; i < Tongsoluong.GetLength(0); i++)
            {
                Tongsoluong[i] = 0;
            }

            for (int i = 0; i < Tongsoluong.GetLength(0); i++)
            {
                for (int j = 0; j < Tongsoluong.GetLength(0); j++)
                {
                    Tongsoluong[i] += Soluong[j, i];
                }
            }

            //Tong doanh thu moi mon hang
            int[] Doanhthuhang = new int[hang.Length];
            for (int i = 0; i < Doanhthuhang.GetLength(0); i++)
            {
                Doanhthuhang[i] = 0;
            }
            for (int i = 0; i < Tongsoluong.GetLength(0); i++)
            {
                Doanhthuhang[i] = Tongsoluong[i] * giatien[i];
            }

            {
                //Nhan vien ban duoc nhieu tien hang nhat
                int max = 0;
                int n = 0;
                for (int i = 0; i < doanhthu_nv.Length; i++)
                {
                    if (doanhthu_nv[i] > max)
                    {
                        max = doanhthu_nv[i];
                        n = i;
                    }
                }
                Console.WriteLine("Nhan vien ban duoc nhieu tien hang nhat la: " + ten[n]);
            }

            {
                //Nhan vien ban duoc nhieu hang nhat
                int max = 0;
                int n = 0;
                for (int i = 0; i < soluong_nv.Length; i++)
                {
                    if (soluong_nv[i] > max)
                    {
                        max = soluong_nv[i];
                        n = i;
                    }
                }
                Console.WriteLine("Nhan vien ban duoc nhieu tien hang nhat la: " + ten[n]);

            }

            {
                //Hang ban chay nhat
                int max = 0;
                int n = 0;
                for (int i = 0; i < Tongsoluong.Length; i++)
                {
                    if (Tongsoluong[i] > max)
                    {
                        max = Tongsoluong[i];
                        n = i;
                    }
                }
                Console.WriteLine("Hang ban chay nhat la: " + hang[n]);

            }

            {
                //Hang ban duoc nhieu tien nhat
                int max = 0;
                int n = 0;
                for (int i = 0; i < Doanhthuhang.Length; i++)
                {
                    if (Doanhthuhang[i] > max)
                    {
                        max = Doanhthuhang[i];
                        n = i;
                    }
                }
                Console.WriteLine("Nhan vien ban duoc nhieu tien hang nhat la: " + hang[n]);

            }




        }

    }
}
