using System;

namespace Exercício_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Environment.UserName;

            Console.WriteLine("Bem-vindo {0}, agora são {1:HH:mm:ss}.", name, DateTime.Now);

            Console.WriteLine("Digite o 1º valor para a soma: ");
            double firstValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o 2º valor para a soma: ");
            double secondValue = Convert.ToDouble(Console.ReadLine());

            double soma = firstValue + secondValue;

            Console.WriteLine("{0}, o resultado da operação é {1}.", name, soma);
        }
    }
}
