using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication3
{
    class Program
    {
        public struct th
        {
            public int block;
        }
        public static int[] memory = new int[1000]; //задаём массив на 1000 элементов
        public static th[] table = new th[10]; //создаём разделы
        static object ob1 = new object();
        public static void show_memory()
        {
            lock (ob1)
            {
                Console.Clear();
                for (int i = 0; i < 1000; i++) //вывод разделов (пустыми)
                    Console.Write(memory[i]);
            }
        }
        static void tr(object obj)
        {
            int numb = Convert.ToInt32(obj); //переопределение 
            alloc(numb); //заполнение разделов
            show_memory(); //вывод раздела
            Thread.Sleep(n.Next(2000, 5000)); //время замедления выполнения программы в процессе
            free(numb); //освобождение (обнуление) раздела
            show_memory();
        }
        static void alloc(int block)
        {
            for (int i = 0; i < 10; i++)
            {
                if (table[i].block == 0) //если блок пустой, то он заполняется
                {
                    table[i].block = block;
                    for (int j = 0; j < 100; j++)
                        memory[i * 100 + j] = block;
                    break;
                }
            }
        }
        static void free(int block)
        {
            for (int i = 0; i < 10; i++)
            {
                if (table[i].block == block) //если не пустой, то он освобождает этот раздел
                {
                    table[i].block = 0;
                    for (int j = 0; j < 100; j++)
                        memory[i * 100 + j] = 0; //обновление раздела (освобождение)
                }
            }
        }
        public static Random n = new Random(); // эти 9 потоков (внизу) запускаются рандомно
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(n.Next(100, 500)); //промежутки м/у ними, когда они запускаются
                new Thread(tr).Start(n.Next(1, 9)); //создаем 9 потоков
            }
        }
    }
}


