using System;

namespace avaliacao
{
  public class Exercicio03
  {

    public static void Ex03()
    {

      //exercicio 03(20)
      int ipi;
      int codA , codB;
      int valA = 0, valB = 0;
      int qtdA = 0, qtdB = 0;
      int x = 0;
      double result;

      Console.WriteLine("ipi : \n");
      ipi = Convert.ToInt32(Console.ReadLine());
      while (x == 0)
      {

        Console.WriteLine("Codigo da primeira peca : \n");
        codA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Valor da primeira peca : \n");
        valA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Quantidade de pecas : \n");
        qtdA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n -------------------\n\n");

        Console.WriteLine("Codigo da segunda peca : \n");
        codB = Convert.ToInt32(Console.ReadLine());

        if (codB == codA)
        {
          Console.WriteLine("Voce esta digitando o mesmo codigo para primeira e segunda peca \n");
          Console.WriteLine("Favor tentar novamente : \n");
          x = 0;
        }
        else
        {
          x = 1;
        }
      }

      Console.WriteLine("Valor da segunda peca : \n");
      valB = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Quantidade de pecas : \n");
      qtdB = Convert.ToInt32(Console.ReadLine());

      result = (double)(valA * qtdA + valB * qtdB) * (ipi / 100 + 1);

      Console.WriteLine("\n Valor Total " + result + "\n");


    }
  }
}
