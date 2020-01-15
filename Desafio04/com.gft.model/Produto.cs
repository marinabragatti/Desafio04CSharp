using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04.com.gft.model
{
    abstract class Produto
    {
        public String Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        //Construtor
        protected Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        protected Produto()
        { }

    }
}
