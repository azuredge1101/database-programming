// See https://aka.ms/new-console-template for more information
class Program 
{
    private static int GCD(int a, int b)
    {
        if (a % b == 0) return b;
        else
            return GCD(b, a % b);
    }
    private static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
        
    }

    static void Main(string[] args)
    {
        Console.Write("1. 請輸入第一個正整數值:");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("2. 請輸入第二個正整數值:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("3. GCD({0},{1})={2}", num1, num2, Program.GCD(num1, num2));
        Console.WriteLine("4. LCM({0},{1})={2}", num1, num2, Program.LCM(num1, num2));
        Console.Read();
    }

}
