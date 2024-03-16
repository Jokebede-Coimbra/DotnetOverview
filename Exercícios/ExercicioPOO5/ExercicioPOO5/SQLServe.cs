using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO5
{
    internal class SQLServe : Database
    {
        public override void Conectar()
        {
            Console.WriteLine("Conectando ao banco de dados SQLServer...");
        }
        public override void Configurar()
        {
            Console.WriteLine("Configurando SQLServe..");
        }
    }
}
