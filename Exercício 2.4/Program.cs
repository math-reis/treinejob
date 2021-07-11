using System;
using System.Collections;

namespace Exercício_2._4
{
    class Program
    {
        private static void ExibirLog(Calculadora c)
        {
            if (c.Log.Count == 0)
            {
                Console.WriteLine("Nenhuma operação realizada.");
            }
            else
            {
                foreach (object obj in c.Log)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
        }

        private static string MontarTela()
        {
            Console.Clear();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Exibir Log");
            Console.WriteLine("9 - Sair");
            Console.WriteLine("Selecione a opção desejada: ");
            return Console.ReadLine();
        }

        private static void LerValores(Operacao o, Calculadora c)
        {
            if (o != Operacao.ExibirLog)
            {
                Console.WriteLine("Digite o valor A: ");
                double va = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor B: ");
                double vb = Convert.ToDouble(Console.ReadLine());

                c.ValorA = va;
                c.ValorB = vb;
            }
        }

        static void Main(string[] args)
        {
            #region Declaração das variáveis
            const string frase = "O resultado da operação {0} com os valores {1} e {2} é {3}.";
            string saida;
            double resultado;
            #endregion

            Calculadora calc = new Calculadora();

            string opcao = MontarTela();

            while (opcao != "9")
            {
                Operacao oper = (Operacao)Convert.ToInt32(opcao);

                LerValores(oper, calc);

                #region Execução dos métodos
                if (oper == Operacao.Somar)
                {
                    Console.WriteLine(frase, "Somar", calc.ValorA, calc.ValorB, calc.Somar());
                }
                else if (oper == Operacao.Subtrair)
                {
                    resultado = calc.Subtrair();
                    saida = string.Format(frase, "Subtrair", calc.ValorA, calc.ValorB, resultado);
                    Console.WriteLine(saida);
                }
                else if (oper == Operacao.Multiplicar)
                {
                    resultado = calc.Multiplicar();
                    Console.WriteLine(string.Format(frase, "Multiplicar", calc.ValorA, calc.ValorB, resultado));
                }
                else if (oper == Operacao.Dividir)
                {
                    saida = string.Format(frase, "Dividir", calc.ValorA, calc.ValorB, calc.Dividir());
                    Console.WriteLine(saida);
                }
                else
                {
                    ExibirLog(calc);
                }
                #endregion

                Console.WriteLine("Pressione Enter para continuar.");
                Console.ReadKey();

                opcao = MontarTela();
            }

            Console.WriteLine("Tchau!");
            Console.ReadKey();
        }
    }
}