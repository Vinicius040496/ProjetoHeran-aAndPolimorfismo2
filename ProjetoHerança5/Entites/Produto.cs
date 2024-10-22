﻿namespace ProjetoHerança5.Entites
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public virtual string EntiquetaPreco()
        {
            return Nome + " R$ " + Preco;
        }
    }
}
