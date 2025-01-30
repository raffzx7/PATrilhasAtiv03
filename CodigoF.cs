using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    	Console.WriteLine("Insira um numero inteiro: ");
    	int n1 = int.Parse(Console.ReadLine());
    	
    	if (n1 % 2 == 0) 
    	{
    		Console.WriteLine("O numero {0} é par ", n1);  
    	}
    	else  
    	{
    		Console.WriteLine("O numero {0} é impar", n1); 
    	}
    	Console.Write("");
    	Console.ReadKey(true);
    }
    
  }
  
}
