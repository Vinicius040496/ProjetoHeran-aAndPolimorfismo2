using ProjetoHerança5.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoHerança5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            Console.Write("Entre com quantidade itens: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Produto #{0}", i);
                Console.Write("Produto Comum,Importado,Usado: C/I/U: ");
                char Resp = char.Parse(Console.ReadLine());
                if (Resp == 'C' || Resp == 'c')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Valor do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Produto produto = new Produto(nome, preco);
                    lista.Add(produto);
                    Console.WriteLine();
                }
                else if (Resp == 'I' || Resp == 'i')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Valor do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Taxa de importação: ");
                    double taxaImportação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Produto_Importado produto_Importado = new Produto_Importado(nome, preco, taxaImportação);
                    lista.Add(produto_Importado);
                    Console.WriteLine();
                }
                else if (Resp == 'U' || Resp == 'u')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Valor do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Data de Fabricação: ");
                    DateTime dataFabricação = DateTime.Parse(Console.ReadLine());
                    ProdutoUsado produtoUsado = new ProdutoUsado(nome, preco, dataFabricação);
                    lista.Add(produtoUsado);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Valor invalido, Tente Novamente!!");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Entiquetas De Preço: ");
            foreach (Produto P in lista)
            {       
                Console.WriteLine(P.EntiquetaPreco().ToString(),CultureInfo.InvariantCulture);
            }
            Console.ReadLine() ;
        }
    }
}
