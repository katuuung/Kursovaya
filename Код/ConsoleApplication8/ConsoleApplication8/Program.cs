using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication6
{
    class Program
    {
        static object obj1 = new object();
        static object obj2 = new object();
        static object obj3 = new object();
        static object obj4 = new object();
        static object obj5 = new object();

        static int[] filelist = new int[15];
        static int[] printerlist = new int[15];

        static int f1;
        static int f2;
        static int f3;
        static int pr;

        static void File_1(int x)
        {
            for (int i = 0; i < 15; i++)
            {
                if (filelist[i] == 0)
                {
                    filelist[i] = x;
                    break;
                }
            }
            lock (obj1)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (filelist[i] == x)
                    {
                        filelist[i] = 0;
                        break;
                    }
                }
                f1 = x;
                Random n = new Random();
                show();
                Thread.Sleep(n.Next(200, 1000));
                f1 = 0;

            }
        }

        static void File_2(int x)
        {
            for (int i = 0; i < 15; i++)
            {
                if (filelist[i] == 0)
                {
                    filelist[i] = x;
                    break;
                }
            }
            lock (obj2)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (filelist[i] == x)
                    {
                        filelist[i] = 0;
                        break;
                    }
                }
                f2 = x;
                Random n = new Random();
                show();
                Thread.Sleep(n.Next(200, 700));
                f2 = 0;

            }
        }

        static void File_3(int x)
        {
            for (int i = 0; i < 15; i++)
            {
                if (filelist[i] == 0)
                {
                    filelist[i] = x;
                    break;
                }
            }
            lock (obj3)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (filelist[i] == x)
                    {
                        filelist[i] = 0;
                        break;
                    }
                }
                f3 = x;
                Random n = new Random();
                show();
                Thread.Sleep(n.Next(200, 700));
                f3 = 0;

            }
        }

        static void Printer(int x)
        {
            for (int i = 0; i < 15; i++)
            {
                if (printerlist[i] == 0)
                {
                    printerlist[i] = x;
                    break;
                }
            }
            lock (obj4)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (printerlist[i] == x)
                    {
                        printerlist[i] = 0;
                        break;
                    }
                }
                pr = x;
                Random n = new Random();
                Thread.Sleep(n.Next(100, 500));
                pr = 0;
            }
        }

        static void show()
        {
            lock (obj5)
            {
                Console.Clear();
                Console.Write("Files (list): ");
                for (int i = 0; i < 15; i++)
                {
                    if (filelist[i] != 0)
                        Console.Write(filelist[i]);
                }
                Console.WriteLine();
                Console.WriteLine("File 1: " + f1);
                Console.WriteLine("File 2: " + f2);
                Console.WriteLine("File 3: " + f3);

                Console.Write("Printer (list): ");
                for (int i = 0; i < 15; i++)
                {
                    if (printerlist[i] != 0)
                        Console.Write(printerlist[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Printer: " + pr);
            }
        }

        static void tr(object ob) //
        {
            int x = Convert.ToInt32(ob);
            Random n = new Random();

            while (true)
            {
                int h = n.Next(1, 4);
                if (h == 1)
                {
                    File_1(x);
                    Printer(x);
                }
                else if (h == 2)
                {
                    File_2(x);
                    Printer(x);
                }
                else
                {
                    File_3(x);
                    Printer(x);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(tr);
            Thread t2 = new Thread(tr);
            Thread t3 = new Thread(tr);
            Thread t4 = new Thread(tr);
            Thread t5 = new Thread(tr);
            Thread t6 = new Thread(tr);
            Thread t7 = new Thread(tr);
            Thread t8 = new Thread(tr);
            Thread t9 = new Thread(tr);
            t1.Start(1);
            t2.Start(2);
            t3.Start(3);
            t4.Start(4);
            t5.Start(5);
            t6.Start(6);
            t7.Start(7);
            t8.Start(8);
            t9.Start(9);
            Console.ReadKey();
        }
    }
}
