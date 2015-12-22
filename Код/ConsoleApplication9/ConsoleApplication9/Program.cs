using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void O(object param)
        {
            string z = Convert.ToString(param);
            for (int i = 0; i < 999; i++)
            {
                Console.Write(z);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(O);
            Thread t2 = new Thread(O);
            Thread t3 = new Thread(O);
            Thread t4 = new Thread(O);
            Thread t5 = new Thread(O);
            Thread t6 = new Thread(O);
            Thread t7 = new Thread(O);
            Thread t8 = new Thread(O);
            t1.Name = "potok 1";
            t2.Name = "potok 2";
            t3.Name = "potok 3";
            t4.Name = "potok 4";
            t5.Name = "potok 5";
            t6.Name = "potok 6";
            t7.Name = "potok 7";
            t8.Name = "potok 8";
            t1.Start("1");
            t2.Start("2");
            t3.Start("3");
            t4.Start("4");
            t5.Start("5");
            t6.Start("6");
            t7.Start("7");
            t8.Start("8");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("все запущено!");
            Console.WriteLine();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            t6.Join();
            t7.Join();
            t8.Join();
        }
    }
}
