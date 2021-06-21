using System;

namespace class02
{
    class Anime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola bienvenido \n Preguntas sobre Anime");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            var apellido = Console.ReadLine();

            Console.Write("Ingrese nombre de su anime favorito: ");
            var AnimeFavorito = Console.ReadLine();

            Console.Write("Ingrese el nombre del ultimo anime que vio: ");
            var UltimoAnime = Console.ReadLine();

            int AnimesVistos = IngresarAnimesVistos();

            Console.Write("¿Cual anime fue el que nenos te gusto?: ");
            var DislikeAnime = Console.ReadLine();

            Console.Write("¿Cual fue el primer anime que viste?: ");
            var firstAnime = Console.ReadLine();

            int AnimesFuturos = IngresarAnimesFuturos();

            Console.Write(" ¿Usted ve el anime solo?: ");
            bool pregunta = Console.ReadLine().ToUpper() == " SI ";

            Console.Write("¿Que genero de anime le gusta ver?");
            var GeneroAnime = Console.ReadLine();

            var Anime = new AnimeBase
            {
                nombre = nombre,
                apellido = apellido,
                AnimeFavorito = AnimeFavorito,
                UltimoAnime = UltimoAnime,
                AnimesVistos = AnimesVistos,
                DislikeAnime = DislikeAnime,
                firstAnime = firstAnime,
                AnimesFuturos = AnimesFuturos,
                pregunta = pregunta,
                GeneroAnime = GeneroAnime,
            };

            Console.WriteLine("Usted dio los siguientes datos sobre anime: ");
            Console.Write($"Nombre: {Anime.nombre} " + "\n");
            Console.Write($"Apellido: {Anime.apellido} " + "\n");
            Console.Write($"Anime Favorito: {Anime.AnimeFavorito} " + "\n");
            Console.Write($"Ultimo Anime: {Anime.UltimoAnime} " + "\n");
            Console.Write($"AnimesVistos: {Anime.AnimesVistos} " + "\n");
            Console.Write($"Anime que no le gusto: {Anime.DislikeAnime} " + "\n");
            Console.Write($"Primer anime que vio: {Anime.firstAnime} " + "\n");
            Console.Write($"Cuantos animes vera en futuro:{Anime.AnimesFuturos} " + "\n");
            Console.Write($"¿Usted ve el anime solo?: {Anime.pregunta} ");
            Console.Write($"Que genero de anime le gusta  {Anime.GeneroAnime} " + "\n");
            Console.WriteLine("Gracias por participar \n Digite cualquier tecla para finalizar.");
            Console.ReadKey();
        }
        static int IngresarAnimesVistos()
        {
            Console.Write("¿Cuantos animes a visto asta el momento?: ");
            int AnimesVistos1;
            while (true)
            {
                string AnimesVistos = Console.ReadLine();
                if (!int.TryParse(AnimesVistos, out AnimesVistos1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return AnimesVistos1;
        }
        static int IngresarAnimesFuturos()
        {
            Console.Write("¿Cuantos animes planeas ver en el futuro?: ");
            int AnimesFuturos1;
            while (true)
            {
                string AnimesFuturos = Console.ReadLine();
                if (!int.TryParse(AnimesFuturos, out AnimesFuturos1))
                {
                    Console.Write("Ingrese un valor numerico:");
                }
                else
                {
                    break;
                };
            };
            return AnimesFuturos1;
        }
    }
}
