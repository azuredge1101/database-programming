using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 83;
            
            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (grade <= 59)
            {
                Console.WriteLine("F");
            }
        }
    }
}
