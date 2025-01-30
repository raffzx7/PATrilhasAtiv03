using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    	Console.WriteLine("Insira um numero inteiro: ");
    	int n1 = int.Parse(Console.ReadLine());
    	Console.WriteLine("Insira outro numero inteiro: ");
    	int n2 = int.Parse(Console.ReadLine());
    	
    	if (n1 > n2) {
      Console.WriteLine("{0} é maior que {1}", n1, n2);
        }   
    	Console.WriteLine("");
    	Console.ReadKey(true);
    }
  }
}
