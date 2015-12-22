using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab_04
{
    class Program
    {
        static int[] memory;
        static Random n = new Random();

        public static void read(int block, int index, int[] mem)
        {
            bool flag = false;
            for (int i = 1; i <= memory.Length; i++)
            {
                if (memory[i] == 0)
                {
                    memory[i] = block;
                    mem[index] = i;
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (!flag && memory[i] == block)
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            if (mem[j] == i)
                            {
                                mem[j] = 0;
                                mem[index] = i;
                                flag = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void show_memory(int[] mem)
        {
            Console.Clear();
            for (int i = 0; i < 9; i++) Console.Write(memory[i]);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 9; i++) Console.Write(mem[i]);
        }

        public static void tr(object ob)
        {
            int index;
            int x = Convert.ToInt32(ob);
            int[] mem = new int[10];
            while (true)
            {
                Thread.Sleep(n.Next(500, 2000));
                index = n.Next(0, 9);
                if (mem[index] == 0)
                {
                    read(x, index, mem);
                    show_memory(mem);
                }

            }
        }

        static void Main(string[] args)
        {
            memory = new int[10];
            new Thread(tr).Start(1);
            new Thread(tr).Start(2);
            new Thread(tr).Start(3);
            Console.ReadKey();
        }
    }
}
