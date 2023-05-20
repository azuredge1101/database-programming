// See https://aka.ms/new-console-template for more information
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("請輸入學生人數:");
            n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num.Length -1; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                    if (num[j] > num[j + 1])
                    {
                        int a = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = a;
                    }
            }
            int good = 9999999, bad = -9999999;
            for (int i = 0; i < n; i++)
            {
                if (num[i] >= 60 && num[i] < good) good = num[i];
                if (num[i] < 60 && num[i] > bad) bad = num[i];
                if (i != 0) Console.Write(" ");
                Console.Write($"{num[i]}");
            }
            Console.Write("\n");
            if (bad == -9999999) Console.WriteLine("best case");
            else Console.WriteLine($"{bad}");
            if (good == 9999999) Console.WriteLine("worst case");
            else Console.WriteLine($"{good}");
            Console.ReadKey();
        }
    }
}
        
            

