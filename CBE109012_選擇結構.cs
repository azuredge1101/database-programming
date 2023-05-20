using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入性別:");
            string a1 = Console.ReadLine();
            Console.WriteLine("輸入身高:");
            double b1 = Convert.ToInt32(Console.ReadLine());
            if (a1 == "男生")
            {
                b1 = (b1 - 80) * 0.7;

            }
            else{ 
                b1 = (b1 - 70) * 0.6;
            }
            Console.WriteLine("傳統的標準體重算法：:\n" + b1.ToString());
        }
    }
}
