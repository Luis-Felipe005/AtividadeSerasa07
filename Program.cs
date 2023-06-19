

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSerasa07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor;
            

            Console.WriteLine("Bem-vindo ao Café expressoooo!");
            Console.WriteLine("Qual o valor que o Sr.(a) deseja depositar?");
            valor = int.Parse(Console.ReadLine());

          
            

            if (valor >= 1 && valor < 6)
            {

                Console.WriteLine("Muito bem! Agora vamos para as opções de café:");

            }

            else (valor <1)
            {
                Console.WriteLine("Valor inválido!");
                Main(null);
            }



            Console.WriteLine(" 1 -Café expresso - R$ 3,00");
            Console.WriteLine("2 - Capuccino - R$ 4,50");
            Console.WriteLine("3 - Mocaccino - R$ 6,00 ");
            Console.WriteLine("4 -Água quente - R$ 1,00");
            int numero;

            Console.WriteLine("Agora escolha uma das opções:");
            numero = int.Parse(Console.ReadLine());


            int Cafe = 3;
            float Capuccino = 4;
            int Mocaccino = 6;
            int Agua_quente = 1;
           
           

            if (valor >= Cafe || valor >= Capuccino || valor >= Mocaccino || valor >= Agua_quente)
            {

                Console.WriteLine("Parabéns, compra finalizada com sucesso!");

            }

            else (valor < Cafe || valor < Capuccino || valor < Mocaccino || valor < Agua_quente)
            {
                Console.WriteLine("Valor insuficiente! Tente novamente!");
                Main(null);
                

            }



            


            Console.ReadKey();


        }
    }
}
