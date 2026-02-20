// See https://aka.ms/new-console-template for more information
using System;

public class NotNumber : Exception
{
    public NotNumber()
    {
        Console.WriteLine("請輸入數字。");
    }
}
public class TooSmall : Exception
{
    public TooSmall()
    {
        Console.WriteLine("終值不可小於初始值。");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string a, x, y;
        int numericValue, m, n;
        while (true)
        {
            try
            {
                x = Console.ReadLine();
                if (!int.TryParse(x, out numericValue)) { throw new NotNumber(); }
                y = Console.ReadLine();
                if (!int.TryParse(y, out numericValue)) { throw new NotNumber(); }
                if (Convert.ToInt32(x) >= Convert.ToInt32(y)) { throw new TooSmall(); }
                a = Console.ReadLine();
                m = Convert.ToInt32(x);
                n = Convert.ToInt32(y);
                if (a == "A" || a == "a")
                {
                    int i, num = 0;
                    for (i = m; i <= n; i++)
                    {
                        num = num + i;
                    }
                    Console.WriteLine("總和為：{0}", num);
                }
                else if (a == "B" || a == "b")
                {
                    int i = m, num = 0;
                    if (i % 2 == 0)
                    {
                        i = i + 1;
                    }
                    while (i <= n)
                    {
                        num = num + i;
                        i = i + 2;
                    }
                    Console.WriteLine("奇數和為：{0}", num);
                }
                else if (a == "C" || a == "c")
                {
                    int i = m, num = 0;
                    if (i % 2 == 1)
                    {
                        i = i + 1;
                    }
                    do
                    {
                        num = num + i;
                        i = i + 2;
                    } while (i <= n);
                    Console.WriteLine("偶數和為：{0}", num);
                }
                else if (a == "D" || a == "d")
                {
                    break;
                }
            }
            catch (NotNumber e) { }
            catch (TooSmall e) { }
        }
    }
}
