using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        public static object obj1, obj2, obj3;
        public static int state = 3;
        static void tr(object obj1)
        {

            a(1);
            b(2);

        }

        static void a(int x)
        {
            lock (obj1)
            {
                if (x == 1)
                {
                    b(x);
                    Console.Write("'");
                }
            }

        }
        static void b(int x)
        {
            lock (obj2)
            {
                if (x == 2)
                {
                    a(x);
                    Console.Write(".");
                }
            }
        }

        static void Main(string[] args)
        {
            obj1 = new object();
            obj2 = new object();
            Thread t1 = new Thread(Program.tr);
            Thread t2 = new Thread(Program.tr);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}

