

using System;

namespace avaliacao
{

  public class Exercicio01
  {

    public static void Ex1()
    {

      // exericio 01(06)1
      double tempo;
      int hora;
      int minutos;
      int segundos;

      Console.WriteLine("Escreva a duração do evento em segundos : \n");
      tempo = Convert.ToDouble(Console.ReadLine());

      hora = (int)(tempo / 3600);
      minutos = (int)((tempo - (hora * 3600)) / 60);
      segundos = (int)(tempo - (hora * 3600) - (minutos * 60));

      Console.WriteLine(" Horas : " + hora + "\n");
      Console.WriteLine(" Minutos : " + minutos + "\n");
      Console.WriteLine(" Segundos : " + segundos);

      Console.WriteLine("\n");
    }


  }

}
