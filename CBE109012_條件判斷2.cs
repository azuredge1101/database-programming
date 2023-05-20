using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入成績1:");
            string a1 = Console.ReadLine();
            Console.Write("請輸入成績2:");
            string b1 = Console.ReadLine();
            float b = (float)(Convert.ToInt32(a1)+ Convert.ToInt32(b1)) / 2;
            Console.WriteLine("平均成績:\n" + b.ToString());
        }
    }
}
