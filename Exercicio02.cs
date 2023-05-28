using System;

namespace avaliacao
{

  public class Exercicio02
  {

    public static void Ex02()
    {
      //exercicio 02(10)
      double h;
      char s = 'h';

      Console.WriteLine("Escreva a sua altura \n");
      h = Convert.ToDouble(Console.ReadLine());
      do
      {
        Console.WriteLine("Escreva se voce e masculino (M) ou femenino (F) \n");
        s = Convert.ToChar(Console.ReadLine());

        s = char.ToUpper(s);

        if (s == 'M')
        {
          Console.WriteLine("Masculino\n");
          Console.WriteLine("IMC = " + Convert.ToDouble((72.7 * h) - 58));
        }
        else if (s == 'F')
        {
          Console.WriteLine("Femenino\n");
          Console.WriteLine("IMC = " + Convert.ToDouble((62.1 * h) - 44.7));
        }
        else
        {
          Console.WriteLine("Tente novamente \n ");
        }
      } while (s != 'F' && s != 'M');

    }

  }
}
