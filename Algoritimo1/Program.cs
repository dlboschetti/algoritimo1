using System;
using System.Text;

namespace Algoritimo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exircício 3 - Jogo da Forca

            int maxTentativas = 11;


            string palavra = "DESENVOLVEDORA";

            int qtdCaracteres = Convert.ToInt32( palavra.Length);

            Console.WriteLine(qtdCaracteres);

            string segredo = "";
            for (int i = 0; i < qtdCaracteres; i++)
            {
                segredo = segredo + "_ ";
            }

            string letra = "";

            int letraAcertada = 0;

            for (int i = 0; i <  maxTentativas; i++)
            {
                if (letraAcertada == qtdCaracteres)
                {
                    Console.WriteLine("Parabéns vc guanhou!");
                    break;
                }
                Console.WriteLine(segredo);
                Console.WriteLine("Informe uma letra:");
                
                letra = Console.ReadLine();
                letra = letra.ToUpper();

                if (letra.Length == 1)
                {
                    int qtdEspacos = 0;
                    for (int l = 0; l < qtdCaracteres; l++)
                    {
                        string letter = palavra.Substring(l, 1);
                        
                        if (l !=0)
                        qtdEspacos ++;

                        if (letter == letra)
                        {
                            letraAcertada++;
                            int indexSubString;
                            if(l==0)
                                indexSubString = l;
                            else
                                indexSubString = l + qtdEspacos;
                            
                            StringBuilder sb = new StringBuilder(segredo);
                            sb[indexSubString] = Convert.ToChar(letter);
                            segredo = sb.ToString();
                            
                        }
                        
                    }
                }
                else
                {
                    if (letra.ToLower() == palavra.ToLower())
                        letraAcertada = palavra.Length;
                        Console.WriteLine("Parabéns! Vc ganhou!");
                    break;
                }
                                

            }
            if (letraAcertada != palavra.Length)
            {
                Console.WriteLine("Nao foi dessa vez!");
                
            }

            //Exircício 2 - Tempo de viagem

            //Console.WriteLine("Informar a distancia (KM):");
            //double  distancia = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informar a velocidade (KM/h):");
            //double velocidade = Convert.ToDouble(Console.ReadLine());

            //double tempo = distancia / velocidade;

            //Console.WriteLine($"Vc chegará ao seu destino em {tempo} horas");

            //Exercício 1 - nota do aluno
            //    Console.WriteLine("DIGITE A PRIMEIRA NOTA"); 
            //    double nota1 = Convert.ToDouble (Console.ReadLine());

            //    Console.WriteLine("DIGITE A SEGUNTA NOTA");
            //    double nota2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("DIGITE A TERCEIRA NOTA");
            //    double nota3 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("DIGITE A QUARTA NOTA");
            //    double nota4 = Convert.ToDouble(Console.ReadLine());

            //    double media = (nota1 + nota2 + nota3 + nota4) / 4;

            //    Console.WriteLine($"A média do aluno foi: {media}");

            //    if (media > 6.9)
            //    {
            //        Console.WriteLine("VC PASSOU DE ANO! PARABÉNS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("INFELIZMENTE VC REPROVOU! PARABÉNS");
            //    }
        }
    }
}
