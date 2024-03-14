using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    internal class LivroFotos
    {
        public int numPaginas {  get; set; }

        public LivroFotos(int numPaginas)
        {
            this.numPaginas = numPaginas;
        }

        public LivroFotos()
        {
            numPaginas = 16;
        }

        public int GetNumeroPaginas()
        {
            return numPaginas;
        }

    }
}
