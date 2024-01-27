using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioImposto
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido() 
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) 
        {
            SalarioBruto += (SalarioBruto * porcentagem) / 100;
        }

        override public string ToString()
        {
            return Nome
            + ", $ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
         
        } 
    }
}
