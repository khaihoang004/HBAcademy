using Buoi2;
using MyNamespace;
using System;
using System.Data;
using System.Net.Security;
using ConsoleApp1;
using System.Xml.Linq;
using Buoi3;
using System.Reflection;
using System.Windows;
using System.Text;

using System.Runtime.Serialization.Formatters;
using System.Collections.Concurrent;
using System.IO.Compression;
using System.Globalization;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace HBAcademy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console .OutputEncoding = System.Text.Encoding.Unicode;

            ////Bài Tập 2
            //Console.WriteLine("Bài Tập 2");

            //MyNamespace.Test1 t1 = new();
            //MyNamespace.MyNamespaceChild.Test2 t2 = new();
            //t1.Hello();
            //t2.Hello();

            //Console.WriteLine(".........................................................");
            //Console.Beep();


            ////Bài Tập 3
            //Console.WriteLine("Bài Tập 3");
            //Buoi2.Rectangle t3 = new();
            //Buoi2.Rectangle t4 = new();




            ////Cách 1

            //Console.WriteLine("Nhap chieu dai: ");
            //t3.Length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhap chieu rong: ");
            //t3.Width = Convert.ToInt32(Console.ReadLine());
            //t3.ShowValue();

            ////Cách 2
            //Console.WriteLine("Nhap chieu dai va chieu rong: ");

            //t3.SetValue(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //t3.ShowValue();




            //Console.WriteLine("Nhap chieu dai: ");
            //t4.Length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhap chieu rong: ");
            //t4.Width = Convert.ToInt32(Console.ReadLine());
            //t4.ShowValue();

            ////Console.Write("{0,20} {1,30}", "Xin chao", "The gioi");
            ////Console.WriteLine();
            ////Console.Beep();
            ////Console.Beep();
            ////Console.Beep();



            //Console.WriteLine(".........................................................");
            //Console.Beep();

            ////Bài tập 4
            //Console.WriteLine("Bài Tập 4");




            //string name, gender, address, email, fname, mname;
            //DateOnly birth;
            //int age;

            //Console.WriteLine("Enter information:");
            //Console.WriteLine("---------------------****--------------------");
            //Console.Write("Enter student name: "); name = Console.ReadLine();
            //Console.Write("Enter gender: "); gender = Console.ReadLine();
            //Console.Write("Enter age: "); age = Convert.ToInt32((Console.ReadLine()));
            //Console.Write("Enter date of birth: "); birth = DateOnly.Parse(Console.ReadLine());
            //Console.Write("Enter address: "); address = Console.ReadLine();
            //Console.Write("Enter email: "); email = Console.ReadLine();
            //Console.Write("Enter father's name: "); fname = Console.ReadLine();
            //Console.Write("Enter mother's name: "); mname = Console.ReadLine();

            //Console.WriteLine("Student name: " + name);
            //Console.WriteLine("Student gender: " + gender);
            //Console.WriteLine("Student age: " + age);
            //Console.WriteLine("Student date of birth: " + birth);
            //Console.WriteLine("Student address: " + address);
            //Console.WriteLine("Student email: " + email);
            //Console.WriteLine("Student's father's name: " + fname);
            //Console.WriteLine("Student's mother's name: " + mname);

            //Console.Beep();
            //Console.Beep();
            //Console.Beep();



            //Console.WriteLine(".........................................................");
            //Console.Beep();


            ////Bài tập 5
            //Console.WriteLine("Bài Tập 5");

            //Buoi2.Bai5 a1 = new Buoi2.Bai5();
            //Buoi2.Bai5 a2 = new Buoi2.Bai5();
            //Buoi2.Bai5 a3 = new Buoi2.Bai5();
            //Buoi2.Bai5 a4 = new Buoi2.Bai5();



            //Console.Write("Nhap Los Angeles 1940: ");
            //a1.Pop40 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap Los Angeles 1950: ");
            //a1.Pop50 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhap NewYork 1940: ");
            //a2.Pop40 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap NewYork 1950: ");
            //a2.Pop50 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhap Chicago 1940: ");
            //a3.Pop40 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap Chicago 1950: ");
            //a3.Pop50 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhap Detroit 1940: ");
            //a4.Pop40 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap Detroit 1950: ");
            //a4.Pop50 = Convert.ToInt32(Console.ReadLine());


            //Console.Write("{0,-20} {1,-5} {2,-15} {3,-5} {4,-15} {5,-15}", "City", "Year", "Population", "Year", "Population", "Change (%)");
            //Console.WriteLine();
            //Console.WriteLine();

            //a1.city = "Los Angeles";
            //a2.city = "New York";
            //a3.city = "Chicago";
            //a4.city = "Detroit";

            //a1.ShowValue();
            //a2.ShowValue();
            //a3.ShowValue();
            //a4.ShowValue();

            //Console.WriteLine(".........................................................");
            //Console.Beep();


            ////Bài tập 7
            //Console.WriteLine("Bài Tập 7");
            //char c;
            //c = Convert.ToChar(Console.ReadLine());
            //byte ascii = (byte)c;
            //Console.WriteLine(ascii);
            //Console.WriteLine();
            //Console.WriteLine("......................");

            //int c3 = Convert.ToInt32(Console.ReadLine());
            //char cha = (char)c3;
            //Console.WriteLine(cha);

            //Console.WriteLine(".........................................................");
            //Console.Beep();

            ////Bài tập 8
            //Console.WriteLine("Bài Tập 8");


            //String s = File.ReadAllText("tailieu.txt");
            ////String[ ] s = File.ReadAllLines("tailieu.txt");
            //Console.WriteLine(s);

            //File.WriteAllText("tailieu.txt", "Day la dai tieng noi Viet Nam");
            //s = File.ReadAllText("tailieu.txt");
            //Console.WriteLine(s);

            //File.AppendAllText("tailieu.txt", " Phat thanh tu Ha Noi, thu do nuoc Cong hoa xa hoi chu nghia Viet Nam");
            //s = File.ReadAllText("tailieu.txt");
            //Console.WriteLine(s);
            //File.WriteAllText("tailieu.txt", "Chuc mung nam moi");

            //Console.WriteLine(".........................................................");
            //Console.Beep();


            //byte x1, y1;
            //x1 = Convert.ToByte((Console.ReadLine()));
            //y1 = Convert.ToByte((Console.ReadLine()));
            //Console.WriteLine(x1 + y1);
            //Console.WriteLine(x1 - y1);
            //Console.WriteLine(x1 * y1);
            //Console.WriteLine(x1 / y1);


            //int x2;
            //int y2;
            //x2 = Convert.ToInt32((Console.ReadLine()));
            //y2 = Convert.ToInt32((Console.ReadLine()));
            //Console.WriteLine(x2 + y2);
            //Console.WriteLine(x2 - y2);
            //Console.WriteLine(x2 * y2);
            //Console.WriteLine(x2 / y2);


            //long x3;
            //long y3;
            //x3 = Convert.ToInt64((Console.ReadLine()));
            //y3 = Convert.ToInt64((Console.ReadLine()));
            //Console.WriteLine(x3 + y3);
            //Console.WriteLine(x3 - y3);
            //Console.WriteLine(x3 * y3);
            //Console.WriteLine(x3 / y3);


            //Boolean x;
            //x = false;

            //Console.WriteLine(x);

            //var a3 = 15;
            //var b3 = 35;

            //string a4 = a3.ToString();
            //string b4 = b3.ToString();
            //Console.WriteLine(a4);
            //Console.WriteLine(b4);
            //Console.WriteLine(a3+b3);
            //Console.WriteLine(a4+b4);


            ////btvn bai 1
            //Boolean a = false;
            //string b = a ? "b=a dung" : "b=a sai";
            //Console.WriteLine(b);


            ////BTVN Bai 2



            //HocVien[] s1 = new HocVien[10];
            //string name, gender, uni, abode, home;
            //DateOnly birth;

            //Console.Write("Nhap so hoc vien: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Nhap thong tin hoc vien "); Console.Write(i + 1); Console.WriteLine(": ");

            //    Console.Write("Ten: "); s1[i].name = Console.ReadLine();
            //    Console.Write("Gioi tinh: "); s1[i].gender = Console.ReadLine();
            //    Console.Write("Ngay sinh: "); s1[i].birth = DateOnly.Parse(Console.ReadLine());
            //    Console.Write("Truong"); s1[i].uni = Console.ReadLine();
            //    Console.Write("Noi o: "); s1[i].abode = Console.ReadLine();
            //    Console.Write("Que quan: "); s1[i].home = Console.ReadLine();
            //}


            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Tra ra thong tin hoc vien "); Console.Write(i + 1); Console.WriteLine(": ");

            //    Console.Write("Ten: "); Console.WriteLine(s1[i].name);
            //    Console.Write("Gioi tinh: "); Console.WriteLine(s1[i].gender);
            //    Console.Write("Ngay sinh: "); Console.WriteLine(s1[i].birth);
            //    Console.Write("Truong"); Console.WriteLine(s1[i].uni);
            //    Console.Write("Noi o: "); Console.WriteLine(s1[i].abode);
            //    Console.Write("Que quan: "); Console.WriteLine(s1[i].home);
            //}

            //Console.WriteLine("Nhap so hoc vien: ");
            //int n = 13 ;
            //HocVien[] s1 = new HocVien[n];



            ////Nhap ket qua
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Nhap thong tin hoc vien "); Console.Write(i + 1); Console.WriteLine(": ");

            //    Console.Write("Ten: "); s1[i].name = Console.ReadLine();
            //    File.AppendAllLines("DuLieuHocVien.txt",s1[i].name);
            //    Console.Write("Gioi tinh: "); s1[i].gender = Console.ReadLine();
            //    Console.Write("Ngay sinh: "); s1[i].birth = DateOnly.Parse(Console.ReadLine());
            //    Console.Write("Truong"); s1[i].uni = Console.ReadLine();
            //    Console.Write("Noi o: "); s1[i].abode = Console.ReadLine();
            //    Console.Write("Que quan: "); s1[i].home = Console.ReadLine();
            //}





            //Doc ra ket qua


            //string[] s = File.ReadAllLines("DuLieuHocVien.txt");

            //for (int i = 0; i < n; i++)
            //{

            //    s1[i].name = s[6 * i];
            //    s1[i].gender = s[6 * i + 1];
            //    s1[i].birth = DateOnly.Parse(s[6 * i + 2]);
            //    s1[i].uni = s[6 * i + 3];
            //    s1[i].abode = s[6 * i + 4];
            //    s1[i].home = s[6 * i + 5];
            //}


            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Tra ra thong tin hoc vien "); Console.Write(i + 1); Console.WriteLine(": ");

            //    Console.Write("Ten: "); Console.WriteLine(s1[i].name);
            //    Console.Write("Gioi tinh: "); Console.WriteLine(s1[i].gender);
            //    Console.Write("Ngay sinh: "); Console.WriteLine(s1[i].birth);
            //    Console.Write("Truong: "); Console.WriteLine(s1[i].uni);
            //    Console.Write("Noi o: "); Console.WriteLine(s1[i].abode);
            //    Console.Write("Que quan: "); Console.WriteLine(s1[i].home);
            //    Console.WriteLine("-----------------~~~-----------------");
            //}




            ////BTVN Bai 3
            //Console.Write("Nhap thang: ");


            //var c = SoNgay.December;

            //Console.Write("Ngay cuoi cua thang trong nam 2023 la: "); Console.WriteLine(c);


            //Console.WriteLine("Nhap a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhap b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //if (a == b)
            //{
            //    Console.WriteLine("A bang B");
            //}
            //if (a > b)
            //{
            //    Console.WriteLine("A lon hon B");
            //}
            //if (a < b)
            //{
            //    Console.WriteLine("A nho hon B");
            //}
            //if (a != b)
            //{
            //    Console.WriteLine("A khong bang B");
            //}
            //if (a <= b)
            //{
            //    Console.WriteLine("A nho hon hoac bang B");
            //}
            //if (a >= b)
            //{
            //    Console.WriteLine("A lon hon hoac bang B");
            //}

            //int y = 5;
            //var z = sizeof(y);

            //string a;
            //bool b;
            //b=true; 
            //Console.WriteLine(sizeof(int));

            //var x = typeof(Rectangle);
            //Console.WriteLine(x.ToString());

            //a = b ? "Dung" : "Sai";

            //if(a is int)
            //{
            //    Console.WriteLine(a.ToString());
            //}

            //Object obj = new StringReader("Hello");
            //StringReader r = obj as StringReader;
            //Console.WriteLine(r);

            //Console.WriteLine("Nhap hai so vao: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a>0)
            //{
            //    if (b > 0)
            //    {
            //        Console.WriteLine(a);
            //        Console.WriteLine(b);

            //    }
            //    if (b < 0)
            //    {
            //        Console.WriteLine(a);
            //    }

            //}
            //else
            //{
            //    if (b > 0)
            //    {
            //        Console.WriteLine(b);

            //    }
            //    if (b < 0)
            //    {
            //        Console.WriteLine("Khong co so nao lon hon 0");
            //    }
            //}


            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Console.WriteLine("Nhap hai so vao: ");
            //int a2 = Convert.ToInt32(Console.ReadLine());
            //int b2 = Convert.ToInt32(Console.ReadLine());

            //aaaaaaa:
            //    char c2 = Convert.ToChar(Console.ReadLine());

            //hehe:
            //    switch (c2)
            //    {

            //        case '+':
            //            Console.WriteLine("Tong hai so la: {0}", a2 + b2);
            //            break;
            //        case '-':
            //            Console.WriteLine("Hieu hai so la: {0}", a2 - b2);
            //            break;
            //        case '*':
            //            Console.WriteLine("Tich hai so la: {0}", a2 * b2);
            //            break;
            //        case '/':
            //            Console.WriteLine("Thuong hai so la: {0}", a2 / b2);
            //            break;
            //        default:
            //            {
            //                Console.WriteLine("Sai, nhap lai di");

            //            }
            //            break;
            //    }






            //ConsoleKeyInfo cki;
            //// Prevent example from ending if CTL+C is pressed.
            //Console.TreatControlCAsInput = true;

            //Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            //Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            //do
            //{
            //    cki = Console.ReadKey();
            //    Console.Write(" --- You pressed ");
            //    if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            //    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            //    if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            //    Console.WriteLine(cki.Key.ToString());
            //} while (cki.Key != ConsoleKey.Escape);



            //int sum=0;
            //Console.Write("Nhap n: ");
            //int n = Convert.ToInt32(Console.ReadLine());




            //int i=0;
            //while (i <= n)
            //{
            //    sum = sum + i;i++;
            //}
            //Console.Write("Tong: "+sum);


            //BTVN Buoi 5
            //Bai 1-1

            //Buoi5.HocVien a0 = new Buoi5.HocVien();
            //Buoi5.HocVien a1 = new Buoi5.HocVien();
            //Buoi5.HocVien a2 = new Buoi5.HocVien();
            //Buoi5.HocVien a3 = new Buoi5.HocVien();
            //Buoi5.HocVien a4 = new Buoi5.HocVien();
            //Buoi5.HocVien a5 = new Buoi5.HocVien();
            //Buoi5.HocVien a6 = new Buoi5.HocVien();
            //Buoi5.HocVien a7 = new Buoi5.HocVien();
            //Buoi5.HocVien a8 = new Buoi5.HocVien();
            //Buoi5.HocVien a9 = new Buoi5.HocVien();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Nhap ten ban thu {0}: ", i);
            //    a0.name = Console.ReadLine();
            //    Console.WriteLine("Nhap diem : ");
            //    a0.diem = Convert.ToInt32(Console.ReadLine());
            //    if (a0.diem >10)
            //    {
            //        Console.WriteLine("Nhap sai so diem: ");
            //    }
            //    else if (a0.diem >= 9)
            //    {
            //        Console.WriteLine("Xuat sac");
            //    }
            //    else if (a0.diem >= 8)
            //    {
            //        Console.WriteLine("Gioi");
            //    }
            //    if (a0.diem >= 6)
            //    {
            //        Console.WriteLine("Trung binh");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yeu");
            //    }
            //}




            ////Bai 2
            //int a, b, c, min;
            //min = 0;
            //Console.Write("So so can so sanh: ");
            //a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write("Nhap vao so thu {0}: ", i + 1);
            //    b = Convert.ToInt32(Console.ReadLine());

            //    if (b < min)
            //    {
            //        min = b;
            //    }
            //}

            //Console.WriteLine("So lon nhat la: {0}", min);

            ////Bai 1-3
            // int a, b, c, max;
            // max = 0;
            // Console.Write("So so can so sanh: ");
            // a  = Convert.ToInt32(Console.ReadLine());

            // for (int i = 0; i < a; i++)
            // {
            //     Console.Write("Nhap vao so thu {0}: ",i+1);
            //     b = Convert.ToInt32(Console.ReadLine());

            //     if (b > max)
            //     {
            //         max = b;
            //     }
            // }

            //Console.WriteLine("So lon nhat la: {0}",max);

            ////Bai 1-4
            //int a, b, sum;
            //sum = 0;
            //Console.Write("So so can so sanh: ");
            //a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write("Nhap vao so thu {0}: ", i + 1);
            //    b = Convert.ToInt32(Console.ReadLine());

            //    if (b%2==0)
            //    {
            //        sum += b;
            //    }
            //}
            //Console.Write("Tong cac so chan trong cac so vua nhap vao la: {0}",sum);


            ////Bai 1-5
            //int a, b, sum;
            //sum = 0;
            //Console.Write("So so can so sanh: ");
            //a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write("Nhap vao so thu {0}: ", i + 1);
            //    b = Convert.ToInt32(Console.ReadLine());

            //    if (b % 2 != 0)
            //    {
            //        sum += b;
            //    }
            //}
            //Console.Write("Tong cac so chan trong cac so vua nhap vao la: {0}", sum);


            ////Bai 2
            //string a = Console.ReadLine();
            //int b = 0;
            //int c = Convert.ToInt32(a.Substring(3, 2));


            //if (c > 0)
            //{

            //    b += 31;
            //    if (c > 1)
            //    {
            //        b += 28;
            //        if (c > 2)
            //        {
            //            b += 31;

            //            if (c > 3)
            //            {
            //                b += 30;
            //                if (c > 4)
            //                {
            //                    b += 31;
            //                    if (c > 5)
            //                    {
            //                        b += 30;
            //                        if (c > 6)
            //                        {
            //                            b += 31;
            //                            if (c > 7)
            //                            {
            //                                b += 31;
            //                                if (c > 8)
            //                                {
            //                                    b += 30;
            //                                    if (c > 9)
            //                                    {
            //                                        b += 31;
            //                                        if (c > 10)
            //                                        {
            //                                            b += 30;
            //                                            if (c > 11)
            //                                            {
            //                                                b += 31;
            //                                            }
            //                                        }
            //                                    }
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    int d = b % 7;
            //    switch (d)
            //    {
            //        case 0:
            //            Console.WriteLine("Thu 7");
            //            break;
            //        case 1:
            //            Console.WriteLine("Chu nhat");
            //            break;
            //        case 2:
            //            Console.WriteLine("Thu 2");
            //            break;
            //        case 3:
            //            Console.WriteLine("Thu 3");
            //            break;
            //        case 4:
            //            Console.WriteLine("Thu 4");
            //            break;
            //        case 5:
            //            Console.WriteLine("Thu 5");
            //            break;
            //        case 6:
            //            Console.WriteLine("Thu 6");
            //            break;
            //    }




            ////Bai 3
            //Console.Write("Nhap vao mot so: ");
            //int a = int.Parse(Console.ReadLine());
            //bool IsPrime = true;
            //if (a < 2)
            //{
            //    IsPrime = false;
            //}
            //for (int i = 2; i < a / 2; i++)
            //{
            //    if (a % i == 0)
            //    {
            //        IsPrime = false;
            //        break;
            //    }
            //}
            //if (IsPrime)
            //{
            //    Console.Write("{0} la so nguyen to", a);
            //}
            //else
            //{
            //    Console.Write("{0} khong phai so nguyen to.",a);
            //}



            ////Bai Tap 4
            //Console.Write("Nhap so nguyen duong thu nhat: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhap so nguyen duong thu hai: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("UCLN cua {0} va {1} la: {2} ", a, b, Buoi5.UCLN(a,b));

            //Console.WriteLine("BCNN cua cua {0} va {1} la: {2}", a, b, Buoi5.BCNN(a, b));



            ////Bai Tap 5
            //Console.WriteLine("Nhap so vao: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Buoi5.PTTSNT(a));



            ////Bai Tap 6
            //Console.Write("Nhap vao mot so: ");
            //int a6 = int.Parse(Console.ReadLine());
            //string b6 = "";
            //for (int i = 0; a6 > 0; i++)
            //{
            //    b6 = a6 % 2 + b6;
            //    a6 = a6 / 2;
            //}
            ////hiển thị Result ra màn hình console
            //Console.WriteLine("So do khi sang he nhi phan: {0}",b6);


            ////Bai Tap 7
            //Console.WriteLine("Nhap vao mot so: ");
            //string a = Console.ReadLine();
            //string b, d;
            //string tram = "";
            //string chuc = "";
            //string donvi = "";
            //string z;
            //string y = "";
            //int n = 0;


            //while (a.Length >= 3) 
            //{

            //    b = a.Substring(a.Length - 3, 3);
            //    a = a.Substring(0, a.Length - 3);
            //    string c = (b.Substring(b.Length - 1, 1));
            //    int k = Convert.ToInt32(c);
            //    Console.WriteLine(a.Length);

            //    switch (k)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            donvi = "mot";
            //            break;
            //        case 2:
            //            donvi = "hai";
            //            break;
            //        case 3:
            //            donvi = "ba";
            //            break;
            //        case 4:
            //            donvi = "bon";
            //            break;
            //        case 5:
            //            donvi = "nam";
            //            break;
            //        case 6:
            //            donvi = "sau";
            //            break;
            //        case 7:
            //            donvi = "bay";
            //            break;
            //        case 8:
            //            donvi = "tam";
            //            break;
            //        case 9:
            //            donvi = "chin";
            //            break;
            //    }

            //    b = b.Substring(0, b.Length - 1);
            //    c = (b.Substring(b.Length - 1, 1));
            //    int k1 = Convert.ToInt32(c);
            //    switch (k1)
            //        {
            //            case 1:
            //                chuc = "muoi";
            //                break;
            //            case 2:
            //                chuc = "hai muoi";
            //                break;
            //            case 3:
            //                chuc = "ba muoi";
            //                break;
            //            case 4:
            //                chuc = "bon muoi";
            //                break;
            //            case 5:
            //                chuc = "nam muoi";
            //                break;
            //            case 6:
            //                chuc = "sau muoi";
            //                break;
            //            case 7:
            //                chuc = "bay muoi";
            //                break;
            //            case 8:
            //                chuc = "tam muoi";
            //                break;
            //            case 9:
            //                chuc = "chin muoi";
            //                break;
            //        }

            //    b = b.Substring(0, b.Length - 1);
            //    c = (b.Substring(b.Length - 1, 1));
            //    int k2 = Convert.ToInt32(c);
            //    if (k2 != 0)
            //    {
            //        if (k1 == 0 && k!=0)
            //        {
            //            chuc = "le";
            //        }

            //        switch (k2)
            //        {
            //            case 1:
            //                tram = "mot tram";
            //                break;
            //            case 2:
            //                tram = "hai tram";
            //                break;
            //            case 3:
            //                tram = "ba tram";
            //                break;
            //            case 4:
            //                tram = "bon tram";
            //                break;
            //            case 5:
            //                tram = "nam tram";
            //                break;
            //            case 6:
            //                tram = "sau tram";
            //                break;
            //            case 7:
            //                tram = "bay tram";
            //                break;
            //            case 8:
            //                tram = "tam tram";
            //                break;
            //            case 9:
            //                tram = "chin tram";
            //                break;
            //        }

            //    }



            //    z = tram + " " + chuc + " " + donvi + " ";
            //    if (n==1)
            //    {
            //        y = "nghin " + y;
            //    }
            //    if (n == 2)
            //    {
            //        y = "trieu " + y;
            //    }
            //    y = z + y;

            //    n++;
            //}
            //   Console.WriteLine(y);











            //Buoi7.Thuchanh();
            //Buoi7.BTVN();

            Buoi9.Bentau();

            //Buoi10.Thuchanh2();




        }
    }
}
    