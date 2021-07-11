using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2._2
{
    class Calculadora
    {
        private double valorA;
        private double valorB;

        public Calculadora(double valorA, double valorB)
        {
            this.valorA = valorA;
            this.valorB = valorB;
        }

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
    }
}
