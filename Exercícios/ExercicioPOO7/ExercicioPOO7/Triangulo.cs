using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO7
{
    internal class Triangulo : Forma
    {
        private double Base { get; set; }
        private double Altura { get; set; }

        public Triangulo(double b, double altura)
        {
            Base = b;
            Altura = altura;
        }

        public override double Area()
        {
            return (Base * Altura) / 2;
        }
    }
}
