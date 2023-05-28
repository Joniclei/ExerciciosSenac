using System;
namespace avaliacao
{
  public class Exercicio05
  {
    public static void Ex05()
    {
      int[] rec = new int[15];
       Random rand = new Random();

      Console.WriteLine("Valore aleatorios : ");

      for (int x = 0; x < 15; x++)
      {
        int valor = rand.Next(1, 100);
        rec[x] = valor;
        Console.WriteLine($"{x + 1} : {rec[x]}");
      }

    }
  }
}
