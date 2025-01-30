using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    	Console.WriteLine("Insira um numero inteiro: ");
    	int n1 = int.Parse(Console.ReadLine());
    	
    	if (n1 >= 0 )
    	{
    		Console.WriteLine("o numero {0} é positivo", n1);  
    	}
    	else
    	{
    		Console.WriteLine("o numero {0} é negativo", n1); 
    	}
    		Console.ReadKey(true);
    }
    
  }
  
}
