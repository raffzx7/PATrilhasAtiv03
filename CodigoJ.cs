using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      	Console.Write("Insira um numero: ");
      float n1 = float.Parse(Console.ReadLine());
      	
      if (n1 == 0) 
      {
      		Console.Write("O numero é igual a 0");
      }
      else {
      	Console.Write("O numero não é igual a 0");
      }
      Console.ReadKey(true);
    }
    
  }
  
}
