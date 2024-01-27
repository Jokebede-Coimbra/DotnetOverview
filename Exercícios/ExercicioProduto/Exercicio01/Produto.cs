using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;



        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
           Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
       
    }
}
