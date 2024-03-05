using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    internal abstract class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Definindo o nome do arquivo");
        }

    }
}
