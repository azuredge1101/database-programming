using System;

class Program {

  static double compute(double money , double percent , int years){

      percent = (percent/100)/12;
      for(int i=0 ; i<years*12 ; i++){
        money = money * (1+percent);
      }
      return money;
  }
  
  public static void Main (string[] args) {
    Console.Write ("請輸入本金: ");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.Write ("請輸入年利率: ");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.Write ("請輸入存款年數: ");
    int z = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    double ans;
    ans = compute(x,y,z);

    Console.Write("本利合為: {0}" ,ans);
  }
}