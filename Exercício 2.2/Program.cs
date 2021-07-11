using System;

namespace Exercício_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor A: ");
            double va = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor B: ");
            double vb = Convert.ToDouble(Console.ReadLine());

            Calculadora calc = new Calculadora(va, vb);

            double resultado;

            resultado = calc.somar();
            Console.WriteLine("A soma de {0} e {1} é igual a {2}.", va, vb, resultado);

            resultado = calc.subtrair();
            Console.WriteLine("A subtração de {0} e {1} é igual a {2}.", va, vb, resultado);

            resultado = calc.multiplicar();
            Console.WriteLine("A multiplicação de {0} e {1} é igual a {2}.", va, vb, resultado);

            resultado = calc.dividir();
            Console.WriteLine("A divisão de {0} e {1} é igual a {2}.", va, vb, resultado);

            Console.ReadKey();
        }
    }
}