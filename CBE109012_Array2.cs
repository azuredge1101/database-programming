using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("請輸入使用者名稱 : ");
    string user = Console.ReadLine();
    if(user=="cat"){
      Console.WriteLine("請輸入密碼 : ");
      string passwdrd = Console.ReadLine();
      if(passwdrd == "good123"){
          Console.WriteLine("{0} 歡迎你 !" ,user);
      }
      else{
          Console.WriteLine("抱歉密碼不正確!");
        
      }
    }
    else if(user=="dog"){
      Console.WriteLine("請輸入密碼 : ");
      string passwdrd = Console.ReadLine();
      if(passwdrd == "best168"){
          Console.WriteLine("{0} 歡迎你 !" ,user);
      }
      else{
          Console.WriteLine("抱歉密碼不正確!");
        
      }
    }
    else if(user=="cow"){
      Console.WriteLine("請輸入密碼 : ");
      string passwdrd = Console.ReadLine();
      if(passwdrd == "happy"){
          Console.WriteLine("{0} 歡迎你 !" ,user);
      }
      else{
          Console.WriteLine("抱歉密碼不正確!");
        
      }
    }
    else if(user=="horse"){
      Console.WriteLine("請輸入密碼 : ");
      string passwdrd = Console.ReadLine();
      if(passwdrd == "first111"){
          Console.WriteLine("{0} 歡迎你 !" ,user);
      }
      else{
          Console.WriteLine("抱歉密碼不正確!");
        
      }
    }
    else if(user=="lion"){
      Console.WriteLine("請輸入密碼 : ");
      string passwdrd = Console.ReadLine();
      if(passwdrd == "lucky777"){
          Console.WriteLine("{0} 歡迎你 !" ,user);
      }
      else{
          Console.WriteLine("抱歉密碼不正確!");
        
      }
    }
    else if(user=="tiger"){
      Console.WriteLine("請輸入密碼 : ");
      string passwdrd = Console.ReadLine();
      if(passwdrd == "OKOK"){
          Console.WriteLine("{0} 歡迎你 !" ,user);
      }
      else{
          Console.WriteLine("抱歉密碼不正確!");
        
      }
    }
    else{
      Console.WriteLine("抱歉使用者不存在!");
    }

    
  }
}