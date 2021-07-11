using System;

namespace Exercício_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            string opcao;
            Operacao operacao;

            #region Enumerador
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("Selecione a opção desejada: ");
            opcao = Console.ReadLine();
            operacao = (Operacao)Convert.ToInt32(opcao);
            #endregion

            Console.WriteLine("Insira o valor A: ");
            double va = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor B: ");
            double vb = Convert.ToDouble(Console.ReadLine());

            Calculadora calc = new Calculadora(va, vb);

            #region Execução dos Métodos
            if (operacao == Operacao.Somar)
            {
                resultado = calc.somar();
                Console.WriteLine("A soma de {0} e {1} é igual a {2}.", va, vb, resultado);
            }
            else if (operacao == Operacao.Subtrair)
            {
                resultado = calc.subtrair();
                Console.WriteLine("A subtração de {0} e {1} é igual a {2}.", va, vb, resultado);
            }
            else if (operacao == Operacao.Multiplicar)
            {
                resultado = calc.multiplicar();
                Console.WriteLine("A multiplicação de {0} e {1} é igual a {2}.", va, vb, resultado);
            }
            else
            {
                resultado = calc.dividir();
                Console.WriteLine("A divisão de {0} e {1} é igual a {2}.", va, vb, resultado);
            } 
            #endregion

            Console.ReadKey();
        }
    }
}