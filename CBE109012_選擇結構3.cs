using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("請輸入公里數");
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入車種:Ａ.自強號　Ｂ.莒光號　Ｃ.　區間車：");
            string b1 = Console.ReadLine();
            double cost;

            if(b1 == "自強號")
            {
                if(a%10 == 0)
                {
                    cost = (a / 10) * 2.27;
                    Console.WriteLine("{0}行駛{1}公里 票價為:{2}", b1, a, cost);
                }
                else
                {
                    cost = ((a / 10) + 1) * 2.27;
                    Console.WriteLine("{0}行駛{1}公里 票價為:{2}", b1, a, cost);
                }
            }
            if (b1 == "莒光號")
            {
                if (a % 10 == 0)
                {
                    cost = (a / 10) * 1.75;
                    Console.WriteLine("{0}行駛{1}公里 票價為:{2}", b1, a, cost);
                }
                else
                {
                    cost = ((a / 10) + 1) * 1.75;
                    Console.WriteLine("{0}行駛{1}公里 票價為:{2}", b1, a, cost);
                }
            }
            if (b1 == "區間車")
            {
                if (a % 10 == 0)
                {
                    cost = (a / 10) * 1.46;
                    Console.WriteLine("{0}行駛{1}公里 票價為:{2}", b1, a, cost);
                }
                else
                {
                    cost = ((a / 10) + 1) * 1.46;
                    Console.WriteLine("{0}行駛{1}公里 票價為:{2}", b1, a, cost);
                }

            }

            




        }
    }
}
