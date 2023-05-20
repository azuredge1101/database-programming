// See https://aka.ms/new-console-template for more information
Console.Write("本期大樂透號碼為:");
Random ranObj = new Random();
int ranNum;
for(int i = 0; i < 6; i++)
{
    ranNum = ranObj.Next(1,50);
    Console.Write(" ");
    Console.Write(ranNum);
}
Console.Read();