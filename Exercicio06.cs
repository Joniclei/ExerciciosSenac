using System;
namespace avaliacao
{
  public class Exercicio06
  {
    public static void Ex06()
    {
      //exercicio 06

      string asta = "*", astb;

      Console.WriteLine(asta);
      for (int l = 0; l < 4; l++)
      {

        astb = asta;
        asta += "*";

        Console.WriteLine(asta);
        Console.WriteLine(astb);
        Console.WriteLine(asta);

      }
      Console.WriteLine("\n");

    }
  }
}
