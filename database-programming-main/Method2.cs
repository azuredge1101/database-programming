// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static int NumDouble(int num)
    {
        return num * (num + 1) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write(" 1. 請輸入一個數值：");
        int num1 = int.Parse(Console.ReadLine());

        int num2 = NumDouble(num1);

        Console.WriteLine("由1累計到{0}的總和為:{1}", num1,num2);
        Console.Read();
    }
}
