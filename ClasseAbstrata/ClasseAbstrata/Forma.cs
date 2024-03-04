using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal abstract class Forma
    {
        // Propriedades
        public string? Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        // Métodos Abstratos
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        // Método Comum
        public string Descricao()
        {
            return "Classe abstrata Forma";
        }
    }
}
