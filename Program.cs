using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variáveis:
           int é inteiro, 
           float é decimal (lembre do f no final) 
           string é texto
           bool é a booleana (true or false)
           char é a de caracter ('entre aspas únicas')
           dynamic é uma variável que pode ser mudada (não recomendada)
           && significa e
           || significa ou
            Parse converte uma texto para número
            static void é uma função vazia, sendo que void significa vazio

           */

            funcao();

            static void funcao ()
            {
                // pergunta 1
                string pergunta1 = "Cóe truta, me diz quando foi a revolução francesa??";
                Console.WriteLine(pergunta1);
                repeticao();
                static void repeticao ()
                {
                    //variaveis de resposta
                    string correto = "pode pá jão, tu mora dos paranauê";
                    string errado = "Ih tu é a maior anta! \nSó pela burrice vou te dar mais uma chance...";
                    //comando
                    string resposta = "";
                    resposta = Console.ReadLine();
                    if (resposta == "1789")
                    {
                        Console.WriteLine(correto);
                    }
                    else
                    {
                        Console.WriteLine(errado);
                        repeticao();
                    }
                }
                // pergunta 2
                Console.WriteLine("\n...\n\nCê acertou malandro, mas duvido que acerte essa...");
                repeticao2();

                static void repeticao2()
                {
                    Console.WriteLine("Hitler ou Putin, quem lutou na 2ª Guerra Mundial?");
                    //variaveis de resposta
                    string correto = "Olôko jão, tu arregaça d+ tio";
                    string errado = "\nPô jão, tão burro quanto uma porta! Tenta de novo...";
                    // comando
                    string resposta2 = "";
                    resposta2 = Console.ReadLine();
                 if (resposta2 == "hitler" || resposta2 == "Hitler")
                    {
                        Console.WriteLine(correto);

                    }else if (resposta2 == "Adolf" || resposta2 == "adolf" || resposta2 == "Adolf Hitler" || resposta2 == "Adolf hitler" || resposta2 == "adolf Hitler" || resposta2 == "adolf hitler")
                    {
                        Console.WriteLine("K7 MANO!! TU É O PICÃO DAS GALÁXIAS, SABE ATÉ O NOME COMPLETO :D");
                            }
                 else
                    {
                        Console.WriteLine(errado);
                        repeticao2();
                    }
                }
                // prêmio
                Console.ReadLine();
                Console.WriteLine("\nMaoe hihihi, mas olha só hihihi \nTemos um pequeno gênio aqui\n Tararara\n  Tararararrarar\n   Hey!\n    Tararararararra\n     Hey!\n      Pegue o seu milhão :)");
                Console.ReadLine();
            }
        }
    }
}
