using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication5
{
    class Program
    {
        static object lockObject = new object();
        static object lockObject2 = new object();
        static object lockObject3 = new object();

        static int[] memory = new int[1000];
        static int[] indexes = new int[10];

        static Random random = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                int fileIndex = random.Next(1, 10);

                if (indexes[fileIndex] == 0)
                {
                    Thread thread = new Thread(CreateThread);
                    thread.Start(fileIndex);

                    Thread.Sleep(random.Next(200, 500));
                }
            }

        }
        static void CreateThread(object index)
        {
            int fileIndex = Convert.ToInt32(index);
            int fileSize = random.Next(20, 100);
            int durationTime = random.Next(1000, 2000);

            for (int i = 1; i < memory.Length; i++)
            {
                if (memory[i] == 0 && IsCorrectAmountOfMemory(i, fileSize))
                {
                    FillMemory(fileIndex, fileSize, i);

                    ShowMemory();

                    Thread.Sleep(durationTime);

                    RemoveFile(fileIndex, fileSize, i);

                    ShowMemory();

                    Thread.Sleep(200);

                    break;
                }
            }
        }
        static void FillMemory(int fileIndex, int fileSize, int i)
        {
            lock (lockObject2)
            {
                for (int j = 0; j < fileSize; j++)
                {
                    memory[i + j] = fileIndex;
                }

                indexes[fileIndex] = i;
            }
        }

        static bool IsCorrectAmountOfMemory(int i, int fileSize)
        {
            bool checkIfSizeCorrect = true;

            if (memory.Length < i + fileSize)
            {
                return false;
            }

            for (int j = 0; j < fileSize; j++)
            {
                if (memory[i + j] != 0)
                {
                    checkIfSizeCorrect = false;
                }
            }
            return checkIfSizeCorrect;
        }

        static void RemoveFile(int fileIndex, int fileSize, int i)
        {
            lock (lockObject3)
            {
                for (int j = 0; j < fileSize; j++)
                {
                    memory[i + j] = 0;
                }

                indexes[fileIndex] = 0;
            }
        }
        static void ShowMemory()
        {
            lock (lockObject)
            {
                Console.Clear();

                for (int i = 1; i < indexes.Length; i++)
                {
                    Console.Write(indexes[i] + "  ");
                }

                Console.Write(Environment.NewLine);

                for (int i = 1; i < memory.Length; i++)
                {
                    Console.Write(memory[i]);
                }
            }
        }
    }
}

