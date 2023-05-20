// See https://aka.ms/new-console-template for more information
int a1, a2, a3, max,min;
Console.WriteLine("1. Input the first value");
a1 = int.Parse(Console.ReadLine());
Console.WriteLine("2. Input the second value");
a2 = int.Parse(Console.ReadLine());
Console.WriteLine("3. Input the third value");
a3 = int.Parse(Console.ReadLine());

if (a1 < a2)
{
    max = a2;
    if (a2 < a3)
    {
        max = a3;
        min= a1;
    }
    else
    {
        if (a3 < a1)
        {
            max = a2;
            min = a3;
        }
        else
        {
            max = a2;
            min= a1;
        }
    }
}
else
{
    max = a1;
    if (a1 > a3)
    {
        max = a1;
        if (a2 > a3) {
            min = a3;
        }
        else
        {
            min = a1;
        }
    }
    else
    {
        max = a3;
        min = a2;
    }
}
Console.WriteLine(value: $"{a1},{a2},{a3}, the max value i:{max},the min value i:{min}");





