using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2._4
{
    class Calculadora
    {
        #region Atributos/Propriedades
        private const string frase = "A operação {0} entre {1} e {2} é {3}.";
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public ArrayList Log { get; }
        #endregion

        public Calculadora()
        {
            Log = new ArrayList();
            this.ValorA = 0;
            this.ValorB = 0;
        }

        private void GravarLog(Operacao operacao, double resultado)
        {
            Log.Add(string.Format(frase, operacao.ToString(), ValorA, ValorB, resultado));
        }

        #region Métodos Públicos
        public double Somar()
        {
            double r = ValorA + ValorB;
            GravarLog(Operacao.Somar, r);
            return r;
        }
        public double Subtrair()
        {
            double r = ValorA - ValorB;
            GravarLog(Operacao.Subtrair, r);
            return r;
        }
        public double Multiplicar()
        {
            double r = ValorA * ValorB;
            GravarLog(Operacao.Multiplicar, r);
            return r;
        }
        public double Dividir()
        {
            double r = ValorA / ValorB;
            GravarLog(Operacao.Dividir, r);
            return r;
        }
        #endregion
    }
}