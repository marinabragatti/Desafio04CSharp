using System;
using System.Collections;
using System.Collections.Generic;
using Desafio04.com.gft.model;
using Desafio04.com.gft.interfaceImposto;

namespace Desafio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J.K.Rowlling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>
            {
                l1,
                l2,
                l3
            };

            List<VideoGame> videoGames = new List<VideoGame>
            {
                ps4,
                ps4Usado,
                xbox
            };

            Loja americanas = new Loja("Americanas", "12345678", livros, videoGames);

            l2.CalculaImposto();
            l3.CalculaImposto();

            ps4Usado.CalculaImposto();
            ps4.CalculaImposto();

            americanas.ListaLivros();
            americanas.ListaVideoGames();
            americanas.CalculaPatrimonio();

        }
    }
}
