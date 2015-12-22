using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        public static object obj1;
        public static int state = 3;
        static void tr(object obj1)
        {
            for (int i = 0; i < 1000000; i++)
            {
             
            }
        }
        static void race()
        {
   
                if (state == 3)
                {
                    state++;
                    if (state != 4)
                    {
                        Console.Write(state);
                    }
                }
                state = 3;

        }
        static void Main(string[] args)
        {
            obj1 = new object();
            Thread t1 = new Thread(Program.tr);
            Thread t2 = new Thread(Program.tr);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}
