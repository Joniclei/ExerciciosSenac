namespace avaliacao
{
  public class Exercicio033
  {
    public static string[] Mes = { "Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };


    public static string Mess(int a)
    {
      a -= 1 ;

      return Mes[a] ;
    }

  }
}
