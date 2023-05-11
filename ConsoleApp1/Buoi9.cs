using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


internal class Buoi9
{

    internal static void Max(int a, int b, int c, int d)
    {
        int lonnhat = a > b ? a > c ? a > d ? a : d : c > d ? c : d : b > c ? b > d ? b : d : c > d ? c : d;
        Console.WriteLine("Gia tri nhon nhat la " + lonnhat);
    }


    internal static void VeTau(int a, int b)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine();
        }
        Console.WriteLine("                 MO PHONG BEN TAU");
        if (a > 0)
        {
            Console.WriteLine("|-------------------------------------------------|");
            {
                Console.Write("|  ");
                Console.Write("/---");
                for (int i = 0; i < a; i++)
                {
                    Console.Write("------");
                }
                for (int i = 0; i < b - a; i++)
                {
                    Console.Write("------");
                }
                Console.WriteLine("--.");
            }

            {

                Console.Write("|  ");
                Console.Write("|   ");
                for (int i = 0; i < a; i++)
                {
                    Console.Write(".__.  ");
                }
                for (int i = 0; i < b - a; i++)
                {
                    Console.Write("      ");
                }
                Console.WriteLine("---\\");
            }
            {
                Console.Write("|  ");
                Console.Write("|   ");
                for (int i = 0; i < a; i++)
                {
                    Console.Write("|__|  ");
                }
                for (int i = 0; i < b - a; i++)
                {
                    Console.Write("      ");
                }
                Console.WriteLine("----\\");
            }
            {
                Console.Write("|  ");
                Console.Write("|   ");
                for (int i = 0; i < a; i++)
                {
                    Console.Write("|__|  ");
                }
                for (int i = 0; i < b - a; i++)
                {
                    Console.Write("      ");
                }
                Console.WriteLine("----/");
            }
            {
                Console.Write("|  ");
                Console.Write("|   ");
                for (int i = 0; i < a; i++)
                {
                    Console.Write("|__|  ");
                }
                for (int i = 0; i < b - a; i++)
                {
                    Console.Write("      ");
                }
                Console.WriteLine("---/");
            }
            {
                Console.Write("|  ");
                Console.Write("\\---");
                for (int i = 0; i < a; i++)
                {
                    Console.Write("------");
                }
                for (int i = 0; i < b - a; i++)
                {
                    Console.Write("------");
                }
                Console.WriteLine("--'");
            }
            Console.WriteLine("|-------------------------------------------------|");
        }
        else if (a == 0)
        {
            Console.WriteLine("|-------------------------------------------------|");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("|                                                 |");
            }

            Console.WriteLine("|          Do hang xong thi tau di roi :)         |");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("|                                                 |");
            }
            Console.WriteLine("|-------------------------------------------------|");
        }
        else
        {
            Console.WriteLine("|-------------------------------------------------|");
            for (int i = 0;i < 2;i++)
            {
                Console.WriteLine("|                                                 |");
            }

            Console.WriteLine("|            Khong co tau dau ma nhin             |");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("|                                                 |");
            }
            Console.WriteLine("|-------------------------------------------------|");
        }

    }
    internal static void Thongke(int t, int a, int b, int c)
    {
        Console.WriteLine("/----------------------------------\\");
        Console.WriteLine("       Thoi diem :     " + t + " s");
        Console.WriteLine(" - So tau vao ben:              " + a);
        Console.WriteLine(" - So tau trong hang doi:       " + b);
        if (c >= 0)
        {
            Console.WriteLine(" - So giay de tau do hang xong: " + c);
        }
        else
        {
            Console.WriteLine(" - So giay de tau do hang xong: 0");
        }
        Console.WriteLine("\\----------------------------------/");
    }
    internal static void Thongbaotauvao()
    {
       
        Console.WriteLine("           .--------------------------.");
        Console.WriteLine("           |  Co tau moi vao do hang  |");
        Console.WriteLine("           '--------------------------'");
        
    }
    internal static void Thongbaotaudoxong()
    {
        
        Console.WriteLine("              .--------------------.");
        Console.WriteLine("              |  Tau do hang xong  |");
        Console.WriteLine("              '--------------------'");
        
    }
    
    internal static void Bentau()
    {
        Console.WriteLine("Thoi gian muon xem trinh gia lap ben tau: ");
        int n = 1 + int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------");
        Console.Clear();

        //Ý tưởng:
        //Tạo ra các mốc thời gian có tàu vào dỡ hàng
        //Cho các con tàu gắn với thời gian dỡ hàng của nó
        //Khi thời gian chạy tới giá trị bằng với giá trị thời gian có tàu vào dỡ hàng thì cho tàu vào bến
        //Khi có tàu vào bến thì auto cho vào hàng đợi
        //Khi không có tàu dỡ hàng thì cho tàu từ hàng đợi vào dỡ hàng


        Random rnd = new Random();

        //Tao ra k tau cung voi gia tri de chuyen hang
        int k = 100;
        int[] Tau = new int[k];
        Queue<int> tau = new Queue<int>();
        for (int i = 0; i < k; i++)
        {
            Tau[i] = rnd.Next(3, 7);
            tau.Enqueue(Tau[i]);
        }


        //Tao ra cac thoi diem co tau vao
        int[] Come = new int[k];
        Queue<int> q = new Queue<int>();    //Hàng đợi các thời điểm có tàu vào

        for (int i = 1; i < k; i++)
        {
            Come[i] = Come[i - 1] + rnd.Next(5, 10);
        }

        q.Enqueue(0);
        for (int i = 1; i < 100; i++)
        {
            q.Enqueue(Come[i]);
        }

        

        //Code Riêu
        int t = 0;  //Biến thời gian 
        int a = 0;  //Biến ghi số tàu đã vào bến
        int b = 0;  //Biến ghi số tàu trong hàng đợi
        int c = 0;  //Biến ghi số lượt còn lại để tàu đang dỡ hàng dỡ hàng xong
        bool d;     //Biến ghi trạng thái có tàu đang dỡ hàng
        bool e;     //Biến ghi trạng thái có tàu vào

        

        int m = 0;
        Queue<int> hangdoi = new Queue<int>();  //Tàu trong hàng đợi

        while (t < n)
        {
            Console.Clear();
            
            
            //Nếu có tàu mới vào thì cho tàu vào hàng đợi
            if (t == q.Peek())
            {
                t = q.Dequeue();
                a++;
                b++;
                hangdoi.Enqueue(tau.Dequeue());
            }
            
            //Nếu không có tàu đang dỡ hàng thì lấy tàu từ trong hàng đợi vào dỡ hàng
            if (c <= 1 & hangdoi.Count > 0)
            {
                c = hangdoi.Dequeue();
                m = c;
                b--;
            }
            else
            {
                c--;
            }


            //Ghi ra so lieu
            Buoi9.Thongke(t,a,b,c);
            
            
            //Ve mo phong ben tau
            Buoi9.VeTau(c, m);

            //Thong bao ve tau do hang
            if (c == m)
            {
                Buoi9.Thongbaotauvao();
            }
            else if (c == 0)
            {
                Buoi9.Thongbaotaudoxong();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                }
            }
            Thread.Sleep(1000);
            
            
            
            t++;

            

        }

       




    }

}

