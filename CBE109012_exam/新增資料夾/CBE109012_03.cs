// See https://aka.ms/new-console-template for more information

Console.WriteLine("==主功能表==");
Console.WriteLine("1.新增作業");
Console.WriteLine("2.修改作業");
Console.WriteLine("3.查詢作業");
Console.WriteLine("0.離開");
Console.WriteLine("= = = = = = =");
Console.Write("請輸入選項[0-3]:");
string answer = Console.ReadLine();
switch (answer)
{
    case "1":
        Console.WriteLine("進入新增作業.....");
        break;
    case "2":
        Console.WriteLine("進入修改作業.....");
        break;
    case "3":
        Console.WriteLine("進入查詢作業.....");
        break;
    case "0":
        Console.WriteLine("離開");
        break;


}

Console.ReadKey();
