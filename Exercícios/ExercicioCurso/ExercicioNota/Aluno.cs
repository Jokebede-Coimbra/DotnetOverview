using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioNota
{
    internal class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];


        public double NotaFinal()
        {
            double res = 0;

            for (int i = 0; i < Notas.Length; i++)
            {
                res += Notas[i];
            }
            return res;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }

        }

    }
}
