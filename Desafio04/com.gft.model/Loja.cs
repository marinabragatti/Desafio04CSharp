using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04.com.gft.model
{
    class Loja
    {
        public string Nome { get; set; }

        public string Cnpj { get; set; }

        List<Livro> livros = new List<Livro>();

        List<VideoGame> videoGames = new List<VideoGame>();

        //Construtores
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;
        }

        public Loja()
        { }

        //Métodos
        public void ListaLivros()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("A loja " + this.Nome + " possui estes livros para venda:");
            livros.ForEach(delegate (Livro livros)
            {
                if(livros.Quantidade != 0) 
                    Console.WriteLine("Titulo: " + livros.Nome + ", preço: " + livros.Preco + ", quantidade: " + livros.Quantidade + " em estoque");
                else
                    Console.WriteLine("A loja não tem livros no seu estoque.");
            });

        }

        public void ListaVideoGames()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("A loja " + this.Nome + " possui estes livros para venda:");
            videoGames.ForEach(delegate (VideoGame videoGames)
            {
                if (videoGames.Quantidade != 0)
                    Console.WriteLine("Video-game: " + videoGames.Nome + ", preço: " + videoGames.Preco + ", quantidade: " + videoGames.Quantidade + " em estoque");
                else
                    Console.WriteLine("A loja não tem video-games no seu estoque.");
            });

        }

        public double CalculaPatrimonio()
        {
            double patrimonio = 0;
            Console.WriteLine("\n----------------------------------------------------------");
            if (livros.Count == 0)
                patrimonio = 0;
            else
            {
                livros.ForEach(delegate (Livro livros)
                {
                    patrimonio = patrimonio + livros.Preco * livros.Quantidade;
                });
            }

            if (videoGames.Count == 0)
                patrimonio += 0;
            else
            {
                videoGames.ForEach(delegate (VideoGame videoGames)
                {
                    patrimonio = patrimonio + videoGames.Preco * videoGames.Quantidade;
                });
            }
            Console.WriteLine("O patrimônio da loja: " + this.Nome + " é de R$ " + patrimonio);
            return 0;
        }
    }
}
