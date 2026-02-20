// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write(i + "*" + j + "=" + (i * j).ToString("00") + " ");
            }
            Console.Write("\r\n");
        }
        Console.ReadLine();
    }
}
