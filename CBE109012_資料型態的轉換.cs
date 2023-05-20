// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        string a1, a2, b1, b2, c1, c2;
        Console.WriteLine("請輸入商品1名稱、金額，及數量：");
        a1 = Console.ReadLine();
        b1 = Console.ReadLine();
        c1 = Console.ReadLine();
        Console.WriteLine("請輸入商品2名稱、金額，及數量：");
        a2 = Console.ReadLine();
        b2 = Console.ReadLine();
        c2 = Console.ReadLine();
        Console.WriteLine("購買明細如下：");
        Console.WriteLine("{0}, {1}元, {2}個", a1, b1, c1);
        Console.WriteLine("{0}, {1}元, {2}個", a2, b2, c2);
        Console.WriteLine("總共{0}元", Int32.Parse(b1) * Int32.Parse(c1) + Int32.Parse(b2) * Int32.Parse(c2));
    }
}
