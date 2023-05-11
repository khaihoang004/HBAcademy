using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Buoi6
    {
        public struct SV
        {
            public string name;
            public int thuchanh, giuaki, cuoiki;
        }
        public static void Print(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("{0,-3}{1,-1}", Matrix[i, j], "|");
                }
                Console.WriteLine();
            }
        }

    }

    //internal static void BTVN()
    //{
    //    //BTVN Buoi6
    //    ////Bai 4


    //    //Console.WriteLine("So hang cua mang");
    //    //int n = int.Parse(Console.ReadLine());
    //    //int[][] numbers = new int[n][];
    //    //int[] dem = new int[n];
    //    //for (int i = 0; i < n; i++)
    //    //{
    //    //    Console.WriteLine("So phan tu cua hang {0} : ", i + 1);
    //    //    dem[i] = int.Parse(Console.ReadLine());
    //    //    Console.WriteLine("Nhap cac phan tu: ");
    //    //    for (int j = 0; j < dem[i]; j++)
    //    //    {
    //    //        numbers[i][j] = int.Parse(Console.ReadLine());
    //    //    }
    //    //}

    //    //for (int i = 0; i < n; i++)
    //    //{
    //    //    for (int j = 0; j < dem[i]; j++)
    //    //    {
    //    //        Console.Write(numbers[i][j]+"   ");
    //    //    }
    //    //    Console.WriteLine();

    //    //}




    //    ////Bai 3

    //    //// Khởi tạo mảng 3 chiều lưu thông tin điểm các bài kiểm tra
    //    //int[,,] scores =
    //    //{
    //    //    {{ 8,  7,  6}, { 7,  6,  8}, { 6,  9, 10}},
    //    //    {{10,  8,  9}, { 7, 10,  8}, { 9, 10,  8}},
    //    //    {{ 9, 10,  7}, {10,  8,  9}, { 7,  6,  8}}
    //    //};

    //    //string[] students = { "Hùng", "Nghĩa", "Hiệp" };


    //    //Console.WriteLine("\tToán\tLý\tHóa");

    //    //for (int i = 0; i < students.Length; i++)
    //    //{
    //    //    string studentName = students[i];
    //    //    double MScore = (scores[i, 0, 0] + scores[i, 0, 1] * 2 + scores[i, 0, 2] * 3) / 6;
    //    //    double PScore = (scores[i, 1, 0] + scores[i, 1, 1] * 2 + scores[i, 1, 2] * 3) / 6;
    //    //    double CScore = (scores[i, 2, 0] + scores[i, 2, 1] * 2 + scores[i, 2, 2] * 3) / 6;

    //    //    // In điểm môn học của từng sinh viên
    //    //    Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", studentName, MScore, PScore, CScore);
    //    //}




    //    ////Bai 4
    //    //Console.Write("Nhap so mang con: ");
    //    //int n = int.Parse(Console.ReadLine());
    //    //int[][] matrix = new int[n][];
    //    //for (int i = 0; i < n; i++)
    //    //{
    //    //    Console.Write("Nhap so phan tu cua mang {0}: ",i+1);
    //    //    int a = int.Parse(Console.ReadLine());
    //    //    matrix[i] = new int[a];
    //    //    for (int j = 0; j < matrix[i].Length; j++)
    //    //    {
    //    //        Console.Write("Nhap gia tri thu {0} cua mang thu {1}: ",j+1,i+1);
    //    //        matrix[i][j] = int.Parse(Console.ReadLine());
    //    //    }
    //    //    Console.WriteLine("--------------------------------");
    //    //}

    //    //Console.WriteLine("--------------------------------");
    //    //Console.WriteLine("Cac gia tri trong mang rang cua:");
    //    //for (int i = 0; i < n; i++)
    //    //{
    //    //    Console.Write($"Mang con thu {i}: ");
    //    //    for (int j = 0; j < matrix[i].Length; j++)
    //    //    {
    //    //        Console.Write($"{matrix[i][j]} ");
    //    //    }
    //    //    Console.WriteLine();
    //    //}






    //    ////Bai 6
    //    //Console.Write("Nhap bac cua ma tran: n = ");
    //    //int n = int.Parse(Console.ReadLine());
    //    //int[,] Matran = new int[n, n];

    //    //for (int i = 0; i < n; i++)
    //    //{
    //    //    for (int j = 0; j < n; j++)
    //    //    {
    //    //        Matran[i, j] = int.Parse(Console.ReadLine());
    //    //    }
    //    //}
    //    //Console.WriteLine("--------------------------------");
    //    //int sum1 = 0;
    //    //for (int i = 0; i < n; i++)
    //    //{
    //    //    sum1 += Matran[i, n - i - 1];
    //    //}
    //    //Console.Write("Tong duong cheo chinh cua ma tran la: ");
    //    //Console.WriteLine(sum1);

    //    //int sum2 = 0;
    //    //for (int i = 0; i < n; i++)
    //    //{
    //    //    sum2 += Matran[i, i];
    //    //}
    //    //Console.Write("Tong duong cheo phu cua ma tran la: ");
    //    //Console.WriteLine(sum2);

    //    //int sum3 = 0;
    //    //for (int i = 0; i < n - 1; i++)
    //    //{
    //    //    for (int j = 0; j < n - 1 - i; j++)
    //    //    {
    //    //        sum3 += Matran[i, j];
    //    //    }
    //    //}
    //    //Console.Write("Tong phia tren duong cheo chinh cua ma tran la: ");
    //    //Console.WriteLine(sum3);

    //    //int sum4 = 0;
    //    //for (int i = n - 1; i > 0; i--)
    //    //{
    //    //    for (int j = n - 1; j > n - i - 1; j--)
    //    //    {
    //    //        sum4 += Matran[i, j];
    //    //    }
    //    //}
    //    //Console.Write("Tong phia duoi duong cheo chinh cua ma tran la: ");
    //    //Console.WriteLine(sum4);


    //    //Bai 7
    //    Console.Write("Nhap kich thuoc cua ma tran: \nn = ");
    //    int n = int.Parse(Console.ReadLine());
    //    Console.Write("m = ");
    //    int m = int.Parse(Console.ReadLine());
    //    int[,] Matran = new int[n, m];
    //    int[] Csum = new int[m];
    //    int[] Rsum = new int[n];
    //    int[] Ctemp = new int[m];
    //    int[] Rtemp = new int[n];



    //    for (int i = 0; i < n; i++)
    //    {
    //        Rsum[i] = 0;
    //        Rtemp[i] = 0;
    //    }
    //    for (int j = 0; j < m; j++)
    //    {
    //        Csum[j] = 0;
    //        Ctemp[j] = 0;
    //    }

    //    for (int i = 0; i < n; i++)
    //    {

    //        for (int j = 0; j < m; j++)
    //        {
    //            Matran[i, j] = int.Parse(Console.ReadLine());
    //            Rsum[i] += Matran[i, j];
    //            Csum[j] += Matran[i, j];
    //        }

    //    }




    //    for (int i = 0; i < n; i++)
    //    {
    //        for (int j = i + 1; j < m; j++)
    //        {
    //            if (Csum[i] > Csum[j])
    //            {
    //                //Nếu Csum[i] > Csum[j] thì hoán đổi giá trị của Csum[i] và Csum[j], cot i va cot j.
    //                int temp = Csum[i];
    //                Csum[i] = Csum[j];
    //                Csum[j] = temp;
    //                for (int k = 0; k < n; k++)
    //                {
    //                    Ctemp[i] = Matran[k, i];
    //                    Matran[k, i] = Matran[k, j];
    //                    Matran[k, j] = Ctemp[i];
    //                }

    //            }
    //        }
    //    }



    //    for (int i = 0; i < m; i++)
    //    {
    //        for (int j = i + 1; j < n; j++)
    //        {
    //            if (Rsum[i] > Rsum[j])
    //            {
    //                //Nếu Rsum[i] > Csum[j] thì hoán đổi giá trị của Rsum[i] và Rsum[j], hang i va hang j.
    //                int temp = Rsum[i];
    //                Rsum[i] = Rsum[j];
    //                Rsum[j] = temp;
    //                for (int k = 0; k < m; k++)
    //                {
    //                    Rtemp[i] = Matran[i, k];
    //                    Matran[i, k] = Matran[j, k];
    //                    Matran[j, k] = Rtemp[i];
    //                }
    //            }
    //        }
    //    }

    //    Console.WriteLine("--------------------------------");
    //    Console.WriteLine("Ma tran sau khi da sap xep: ");
    //    Buoi6.Print(Matran);
    //}





}
