// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("請輸入欲顯示到第幾個費式係數：");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("費式數列：");
        int q = 0, w = 1, e = 0;
        for (int i = 0; i < a; i++)
        {
            e = w;
            w = q + w;
            q = e;
            Console.WriteLine(q);
        }
    }
}

