using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      	Console.Write("Insira o maior numero: ");
      int n1 = int.Parse(Console.ReadLine());
      
      Console.Write("Insira o menor numero: ");
      int n2 = int.Parse(Console.ReadLine());
      
      int resultado = Math.Abs(n2 - n1);
      	
      if (resultado = 10) {
      		Console.Write("A diferença entre o numero {0} e o numero {1} é igual a 10.", n1, n2);
      }
      else if (resultado - 10)
      {
      	Console.Write("A diferença entre o numero {0} e o numero {1} é  menor que 10", n1, n2);
      }
      else {
      		Console.Write("A diferença entre o numero {0} e o numero {1} é maior que 10.", n1, n2);
      }
      Console.ReadKey(true);
    }
    
  }
  
}
