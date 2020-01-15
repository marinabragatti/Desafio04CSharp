using System;
using System.Collections.Generic;
using System.Text;
using Desafio04.com.gft.interfaceImposto;

namespace Desafio04.com.gft.model
{
    class Livro : Produto, Imposto
    {
        public string Autor { get; set; }

        public string Tema { get; set; }

        public int QtdePag { get; set; }

        //Construtores
        public Livro(string nome, double preco, int quantidade, string autor, string tema, int qtdePag) : base(nome, preco, quantidade)
        {
            Autor = autor;
            Tema = tema;
            QtdePag = qtdePag;
        }

        public Livro()
        { }

        public double CalculaImposto()
        {
            double imposto = 0;
            if (this.Tema == "educativo")
                Console.WriteLine("Livro educativo não tem imposto: " + this.Nome);
            else
            {
                imposto = Preco * 0.1;
                Console.WriteLine("R$ " + imposto + " de impostos sobre o livro " + this.Nome);
            }
            return 0;
        }
    }
}
