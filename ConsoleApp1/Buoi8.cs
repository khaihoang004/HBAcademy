using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace HBAcademy
{
    internal class Buoi8
    {
        internal static void Thuchanh1()
        {
            ArrayList A1 = new ArrayList();
            ArrayList A2 = new ArrayList();
            bool n1 = false;
            bool n2 = true;

            A1.Add(5);
            A1.Add("Yahooo");
            A1.Add(n1);

            A2.Add(9);
            A2.Add("Weeeeee");
            A2.Add(n2);

            A1.Insert(1, "Never gonna give you up");
            A1.Insert(2, "Never gonna let you down");
            A1.Insert(1, A2);

            for (int i = 0; i < A1.Count; i++)
            {
                Console.WriteLine(A1[i]);
            }
            for (int i = 0; i < A2.Count; i++)
            {
                Console.WriteLine(A2[i]);
            }

            A1.Remove(5);
            A2.RemoveAt(2);
            A2.RemoveRange(0, 1);

            Console.WriteLine("Nhap phan tu can kiem tra");
            var n = Console.ReadLine();
            for (int i = 0; i < A1.Count; i++)
            {

                if (n == A1[i])
                {
                    Console.WriteLine($"Trong ArrayList A1 co phan tu {n}");
                }
            }


        }
        internal static void Thuchanh2()
        {

            List<int> a = new List<int>();
            Console.WriteLine(a.Capacity);

            for (int i = 0; i < 10; i++)
            {
                a.Add(2);
                a.Add(5);
            }
            int temp;


            for (int i = 0; i < a.Count / 2; i++)
            {
                temp = a[i];
                a[i] = a[a.Count - 1 - i];
                a[a.Count - 1 - i] = temp;
            }
            {
                int k = 0;
                while (a.Contains(5) == true)
                {
                    a.Remove(5);
                }

            }
            for (int i = 0; i < a.Count / 2; i++)
            {
                Console.WriteLine(i + " " + a[i]);

            }

            //Sap xep theo thu tu tang dan
            a.Sort();

            //Dao nguoc lai de sap xep theo thu tu giam dan
            for (int i = 0; i < a.Count / 2; i++)
            {
                temp = a[i];
                Console.WriteLine(i);
                a[i] = a[a.Count - 1 - i];
                a[a.Count - 1 - i] = temp;
            }

        }

        public class Dulieusinhvien
        {
            public string Name { get; set; }
            public string Thoigianden { get; set; }
        }
        internal static void BTVN()
        {
            List<Dulieusinhvien> SV = new List<Dulieusinhvien>(10);
            
            Queue queue = new Queue(10);
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue($"Sinh vien {i+1}");
                
            }

            object[] temp = queue.ToArray();
            while (queue.Count > 0)
            {
                Console.WriteLine($"{queue.Dequeue()}");
            }
            



        }
        internal static void BTVN2()
        {

            //Stack a0 = new Stack();
            //a0.Push(1);
            //a0.Push(2);
            //a0.Push(3);
            //Console.WriteLine("Gia tri dau:{0}", a0.Peek());
            //Console.WriteLine("Stack a");
            //foreach (var x in a0)
            //{
            //    Console.WriteLine(x);
            //}
            //if (a0.Contains(1)) Console.WriteLine("Ton tai so 1");
            //object[] b0 = new object[3];
            //a0.CopyTo(b0, 0);
            //Console.WriteLine("Mang b");
            //foreach (var y in b0)
            //{
            //    Console.WriteLine(y);
            //}
            //a0.Pop();
            //Console.WriteLine("Xoa phan tu dau");
            //foreach (var z in a0)
            //{
            //    Console.WriteLine(z);
            //}
            //a0.Clear();
            //Console.WriteLine("Xoa het phan tu");
            //foreach (var t in a0)
            //{
            //    Console.Write(t);
            //}



            //Queue a = new Queue();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Nhap ten cac ban:");
            //    a.Enqueue(Console.ReadLine);
            //}
            //foreach (var x in a)
            //{
            //    Console.WriteLine(x);
            //}
            //if (a.Contains("Bao")) 
            //{ 
            //    a.Dequeue(); 
            //}


            ////Bai 5
            //Stack a2 = new Stack();
            //Queue b = new Queue();
            //for (int i = 1; i < 11; i++)
            //{
            //    if (i % 2 == 0) { a2.Push(i); }
            //    else { b.Enqueue(i); }
            //}
            //Console.WriteLine("Stack a:");
            //foreach (int x in a2) { Console.WriteLine(x); }
            //Console.WriteLine("Queue b:");
            //foreach (int y in b) { Console.WriteLine(y); }

            //Bai 6
            Console.Write("Nhap so nguyen N=");
            int N = int.Parse(Console.ReadLine());
             
            Queue a3 = new Queue();
            for (int i = 1; i <= N; i++)
            {
                string nhiphan = Convert.ToString(i, 2);
                a3.Enqueue(nhiphan);
            }
            while (a3.Count > 0)
            {
                var so = a3.Dequeue();
                Console.WriteLine($"{so}, con lai {a3.Count} so");
            }




        }
        internal static void ThuchanhDictionary()
        {

            Console.WriteLine("Danh sach so dien thoai: ");
            Dictionary<string,string> SoDienThoai = new Dictionary<string,string>();
            SoDienThoai.Add("01234", "Khai");
            SoDienThoai.Add("02345", "Bao");
            SoDienThoai.Add("03456", "Nhung");
            SoDienThoai.Add("04567", "Phuc");




            //for (int i = 0;i < 2;i++)
            //{
            //    Console.WriteLine("Nhap so dien thoai:");

            //    SoDienThoai.Add(Console.ReadLine(),Console.ReadLine());
            //}

            //Tim kiem ten theo so dien thoai
            Console.WriteLine("---------------------------");
            Console.WriteLine("Tim kiem ten theo so dien thoai");
            Console.WriteLine("Nhap so dien thoai: ");
            Console.WriteLine(SoDienThoai[Console.ReadLine()]);



            
            //Hien thi danh sach so dien thoai
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hien thi trong danh sach so dien thoai");
            foreach (KeyValuePair<string,string> key in SoDienThoai) 
            {
                Console.WriteLine(key); 
            }

            Console.WriteLine("Xoa mot so dien thoai:");
            SoDienThoai.Remove(Console.ReadLine());
            foreach (KeyValuePair<string, string> key in SoDienThoai)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Xoa mot ten: ");
            string a = Console.ReadLine();
            if (SoDienThoai.ContainsValue(a))
            {
                foreach (var key in SoDienThoai)
                {
                    if (key.Value == a)
                    {
                        SoDienThoai.Remove(key.Key);
                    }
                }
            }
            foreach (KeyValuePair<string, string> key in SoDienThoai)
            {
                Console.WriteLine(key);
            }




        }
        internal static void HashSet()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

        }
    }
}
