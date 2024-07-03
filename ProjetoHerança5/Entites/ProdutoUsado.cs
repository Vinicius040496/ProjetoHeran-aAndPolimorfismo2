using System;
using System.Globalization;

namespace ProjetoHerança5.Entites
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataFabricação { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricação)
            : base(nome, preco)
        {
            DataFabricação = dataFabricação;
        }
        public override string EntiquetaPreco()
        {
            return Nome.ToString() + " (Produto Usado)" + "R$ " + Preco.ToString("f2", CultureInfo.InvariantCulture) + " (Data De Fabricação: " + DataFabricação.ToString("dd/MM/yyyy") + ")";
        }
    }
}
