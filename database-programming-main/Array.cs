using System;

class Program {
  public static void Main (string[] args) {
    int[] array = {0,0,0,0,0,0,0,0,0,0};     
    for(int i=0 ; i<10 ; i++){
      Console.WriteLine("input number {0} : ",i+1);
      int temp = Convert.ToInt32(Console.ReadLine());
      array[i] = temp;
    }
    Array.Sort(array);
    Console.WriteLine("min:{0} max:{1}" , array[0] , array[9]);
    
  }
}