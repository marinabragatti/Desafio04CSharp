using System;
using System.Collections.Generic;
using System.Text;
using Desafio04.com.gft.interfaceImposto;

namespace Desafio04.com.gft.model
{
    class VideoGame : Produto, Imposto
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public bool IsUsado { get; set; }

        public VideoGame(string nome, double preco, int quantidade, string marca, string modelo, bool isUsado) :base(nome, preco, quantidade)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public VideoGame()
        { }

        public double CalculaImposto()
        {
            double imposto = 0;
            if(this.IsUsado)
            {
                imposto = Preco * 0.25;
                Console.WriteLine("Imposto " + this.Nome + " " + this.Modelo + " usado, R$ " + imposto);
            }
            else
            {
                imposto = Preco * 0.45;
                Console.WriteLine("Imposto " + this.Nome + " " + this.Modelo + " R$ " + imposto);
            }
            return 0;
        }
    }
}
