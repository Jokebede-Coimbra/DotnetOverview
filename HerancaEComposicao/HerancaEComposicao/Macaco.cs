using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEComposicao
{
    internal class Macaco : Animal

    {
        // A propriedade é privada e somente leitura para n ser alterada após receber a instÂncia no construtor
        private readonly ComportamentoAndar _comportamentoAndar;

        public Macaco(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Macaco));
            _comportamentoAndar.Andar();
        }

    }
}
