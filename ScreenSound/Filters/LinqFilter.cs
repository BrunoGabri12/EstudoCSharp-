
using ScreenSound.Models;
using System.Linq;


namespace ScreenSound.Filters
{
    internal class LinqFilter
    {
        public static void FilterByAllGenres(List<Music> musicas)
        {
            var allGeners = musicas.Select(generos => generos.Genero).Distinct().ToList();

            allGeners.ForEach(genero =>  Console.WriteLine(genero));
        }

        public static void FilterByArtistName(List<Music> musicas)
        {
            var allArtists = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
          
            allArtists.ForEach(artist => Console.WriteLine(artist));
        }

        public static void FilterArtistsByGener(List<Music> musicas, string gener) {
           var artistsByGener = musicas.Where(music => music.Genero.Contains(gener)).Select(musica => musica.Artista).Distinct().ToList();
           artistsByGener.ForEach(artist => Console.WriteLine(artist));
        }
    }
}
