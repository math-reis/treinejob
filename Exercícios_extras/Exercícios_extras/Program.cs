using System;

namespace Exercícios_extras
{
    class Program
    {
        static void Ex_1()
        {
            //Elabore um algoritmo que calcule a idade média de 5 alunos.

            int idade;
            int soma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira a idade do aluno {0}: ", i + 1);
                idade = Convert.ToInt32(Console.ReadLine());
                soma = idade + soma;
            }

            Console.WriteLine("A soma das idades é {0}.", soma);
            Console.WriteLine("A média das idades é {0}.", soma / 5.0);
        }

        static void Ex_2()
        {
            //Crie um algoritmo que verifique se um número informado é par ou impar.

            Console.WriteLine("Insira um número intero qualquer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", num);
            }
            else
            {
                Console.WriteLine("O número {0} é impar.", num);
            }
        }

        static void Ex_3()
        {
            //Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos.
            //O algoritmo deverá ler a idade de 5 pessoas.

            int idade;
            int maIdade = 0;
            int meIdade = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira a idade da pessoa {0}: ", i + 1);
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 18)
                {
                    maIdade++;
                }
                else
                {
                    meIdade++;
                }
            }

            Console.WriteLine("Maiores de idade: {0}", maIdade);
            Console.WriteLine("Menoress de idade: {0}", meIdade);
        }

        static void Ex_4()
        {
            //Faça um algoritmo que calcule e exiba o salário reajustado de 5 funcionários de
            //acordo com a seguinte regra: salário de até 300, reajuste de 50 %; salário maior
            //que 300, reajuste de 30 %.

            double salario;

            Console.WriteLine("Insira o salário: ");
            salario = Convert.ToInt32(Console.ReadLine());

            if (salario <= 300)
            {
                salario = salario * 1.5;
            }
            else
            {
                salario = salario * 1.3;
            }

            Console.WriteLine("O salário reajustado é: {0}", salario);
        }

        static void Main(string[] args)
        {
            Ex_4();
            Console.ReadLine();
        }
    }
}
