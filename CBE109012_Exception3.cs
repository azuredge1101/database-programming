// See https://aka.ms/new-console-template for more information
Console.WriteLine("請輸入初始值:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("請輸入初始值:");
int b = Convert.ToInt32(Console.ReadLine());


for(int x = a;x <= b;x++)
{
    int n = 0;
    for (int i = 1; i <= x; i++)
    {
        if (x % i == 0)
        {
            n = n + 1;
        }
    }
    if (n == 2)
    {
        Console.WriteLine(x);
    }
}