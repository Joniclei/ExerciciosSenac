using System;

namespace avaliacao
{
  public class Exercicio04
  {
    public static void Ex04()
    {
      //exercico 04(25)
      int qtdP;
      double altI, altS = 0;
      Console.WriteLine(" Quantidade de pessoas : \n");
      qtdP = Convert.ToInt32(Console.ReadLine());

      for (int x = 1; x <= qtdP; x++)
      {
        Console.WriteLine(" Qual altura : \n");
        altI = Convert.ToDouble(Console.ReadLine());
        altS += altI;
      }
      Console.WriteLine("media :" + altS / qtdP + "\n");


    }
  }
}
