using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2._3
{
    class Calculadora
    {
        #region Atributos
        private double valorA;
        private double valorB;
        #endregion

        #region Construtor
        public Calculadora(double valorA, double valorB)
        {
            this.valorA = valorA;
            this.valorB = valorB;
        } 
        #endregion

        #region Métodos Públicos
        public double somar()
        {
            return valorA + valorB;
        }
        public double subtrair()
        {
            return valorA - valorB;
        }
        public double multiplicar()
        {
            return valorA * valorB;
        }
        public double dividir()
        {
            return valorA / valorB;
        } 
        #endregion
    }
}