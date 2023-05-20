// See https://aka.ms/new-console-template for more information
using System;

namespace helloword

{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            string[] b = { "陳一", "張三", "王五" };
            int max = 0;
            string small= "0";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("第{0}鄰各候選人得票數:", i + 1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{j + 1}. {b[j]} :");
                    a[j, i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("----------------------------");
            }
            Console.WriteLine("==========================");
            Console.WriteLine("候選人 第一鄰 第二鄰 第三鄰 總得票數");
            Console.WriteLine("==========================");

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                Console.Write($"{b[i]}");
                for (int j = 0; j < 3; j++)
                {
                    sum += a[i, j];
                    Console.Write($"\t{a[i, j]}");
                }
                if (sum > max)
                {
                    small = b[i];
                    max = sum;
                }
                Console.WriteLine($"\t{sum}");
            }
            Console.WriteLine($"\n=== {small} 最高票當選, 共計: {max} 票");
        }
    }
}
