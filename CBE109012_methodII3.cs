// See https://aka.ms/new-console-template for more information
using System;

public class GetMin
{
    public static int gm(int a, int b)
    {
        if (a > b) { return b; }
        else { return a; }
    }
    public static int gm(int[] a)
    {
        int min = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        return min;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 2, 10, 8 };
        int[] b = { 33, -22, 11, 44, 0 };
        Console.WriteLine("兩數 3 和 -6 之最小數為 {0}", GetMin.gm(3, -6));
        Console.WriteLine("陣列(2, 10, 8)中最小值為 {0}", GetMin.gm(a));
        Console.WriteLine("陣列(33, -22, 11, 44, 0)中最小值為 {0}", GetMin.gm(b));
    }
}
