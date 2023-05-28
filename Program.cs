using System;

namespace avaliacao
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("JONICLEI BERNARDO JUNIOR - 6pendente % 10 pendente while 20 25 29");
            int op;

            do
            {
                Console.WriteLine("\n \t Escolha uma opção a seguir: \n");
                Console.WriteLine("\n [1] Exercício 1");
                Console.WriteLine("\n [2] Exercício 2");
                Console.WriteLine("\n [3] Exercício 3");
                Console.WriteLine("\n [4] Exercício 4");
                Console.WriteLine("\n [5] Exercício 5");
                Console.WriteLine("\n [6] Use a sua criatividade");
                Console.WriteLine("\n [7] Exercício 31");
                Console.WriteLine("\n [8] Exercício 32");
                Console.WriteLine("\n [9] Exercício 33");
                Console.WriteLine("\n [10] Exercício 34\n");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {

                            Exercicio01.Ex1();
                            Console.WriteLine("Digite qualquer tecla para continuar:");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        };
                    case 2:
                        {

                            Exercicio02.Ex02();


                            Console.WriteLine("Digite qualquer tecla para continuar:");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        };
                    case 3:
                        {

                            Exercicio03.Ex03();


                            Console.WriteLine("Digite qualquer tecla para continuar:");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        };
                    case 4:
                        {

                            Exercicio04.Ex04();

                            Console.WriteLine("Digite qualquer tecla para continuar:");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        };
                    case 5:
                        {
                            Exercicio05.Ex05();

                            Console.WriteLine("Digite qualquer tecla para continuar:");
                            Console.ReadKey();
                            Console.Clear();


                            break;
                        };
                    case 6:
                        {

                            Exercicio06.Ex06();

                            Console.WriteLine("Digite qualquer tecla para continuar:");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        };
                    case 7:
                        {
                            int num = 0;
                            do
                            {
                                Console.WriteLine("Escolha uma opcao : \n [1] Combustivel A \n [2] Combustivel B \n [3] Combustivel C");
                                num = int.Parse(Console.ReadLine());


                                switch (num)
                                {
                                    case 1:
                                        {
                                            Combustivel.CombA();
                                            Console.ReadLine();

                                            break;
                                        }
                                    case 2:
                                        {
                                            Combustivel.CombB();
                                            Console.ReadLine();

                                            break;
                                        }
                                    case 3:
                                        {
                                            Combustivel.CombC();
                                            Console.ReadLine();

                                            break;
                                        }
                                }

                                {

                                }



                                string final = num == 1 || num == 2 || num == 3 ? "Até buscapé" : " Favor digite um valor valido";
                                Console.WriteLine(final);

                            } while (num != 1 && num != 2 && num != 3);




                            break;
                        }
                    case 8:
                        {
                            // que leia um número inteiro de 1 a 7 e imprima o dia da semana correspondente,utilizando a estrutura switch case.
                            //Implemente uma função que recebe o número e retorna onome do dia da semana correspondente.
                            int ds = 0;

                            do
                            {
                                Console.WriteLine("Escreva um valor de 1 até 7");
                                ds = int.Parse(Console.ReadLine());
                                switch (ds)
                                {
                                    case 1:
                                        {
                                            Diasemana.a();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Diasemana.b();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Diasemana.c();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Diasemana.d();
                                            break;
                                        }
                                    case 5:
                                        {
                                            Diasemana.e();
                                            break;
                                        }
                                    case 6:
                                        {
                                            Diasemana.f();
                                            break;
                                        }
                                    case 7:
                                        {
                                            Diasemana.g();
                                            break;
                                        }

                                }
                                string final = ds == 1 || ds == 2 || ds == 3 || ds == 4 || ds == 5 || ds == 6 || ds == 7 ? "Até buscapé" : " Favor digite um valor valido";
                                Console.WriteLine(final);

                            } while (ds != 1 && ds != 2 && ds != 3 && ds != 4 && ds != 5 && ds != 6 && ds != 7);
                            break;
                        }
                      case 9 :
                      {
                        Console.WriteLine("Digite uma valor para mes");
                        int x = Convert.ToInt32(Console.ReadLine());



                        string resultado = Exercicio033.Mess(x);
                        Console.WriteLine(resultado);


                        break ;
                      }
                      case 10 :
                      {
                        Console.WriteLine("Escreva uma letra :");
                        string letra = Console.ReadLine();


                        switch(letra){
                            case "a" or "e" or "i" or "o" or "u":
                            {
                                Exercicio34.Vogal();
                                break;

                            }
                            case "b" or "c" or "d" or "f" or "g" or "h" or "j" or "k" or "l" or "m" or "n" or "p" or "q" or "r" or "s" or "t" or "v" or "w" or "x" or "y" or "z" :
                            {   Exercicio34.Consoante();

                                break;
                            }

                        }
                        break;
                      }
                    /*case 7:
                      {
                        Console.WriteLine("Finalizando");
                        break;
                      };*/
                    default:
                        {
                            Console.WriteLine("\nOpção inválida");
                            break;
                        }

                }

            }
            while (op != 7);
            Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");
        }
    }
}
