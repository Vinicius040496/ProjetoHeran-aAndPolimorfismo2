using System.Globalization;

namespace ProjetoHerança5.Entites
{
    internal class Produto_Importado : Produto
    {
        public double TaxaImportação { get; set; }

        public Produto_Importado()
        {

        }
        public Produto_Importado(string nome, double preco, double taxaImportação)
            : base(nome, preco)
        {
            TaxaImportação = taxaImportação;
        }
        public double TaxaImposto()
        {
            return Preco + TaxaImportação;
        }
        public override string EntiquetaPreco()
        {
            return Nome.ToString() + " R$ " + TaxaImposto().ToString("f2", CultureInfo.InvariantCulture) + " (Taxa de importação: " + TaxaImportação.ToString("f2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
