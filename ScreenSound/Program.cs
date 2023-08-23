using ScreenSound.Filters;
using ScreenSound.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Music>>(response)!;

        Console.WriteLine(musicas.Count.ToString());
     
        LinqFilter.FilterArtistsByGener(musicas,"fggfg");

        FavoriteMusics m = new FavoriteMusics("Test");

        m.AddFavoriteMusics(musicas[3]);
        m.AddFavoriteMusics(musicas[30]);
        m.AddFavoriteMusics(musicas[300]);
        m.AddFavoriteMusics(musicas[900]);

        m.PrintFavoriteMusics();

    } catch (Exception ex)
    {
         Console.WriteLine(ex.ToString());
    }
    
}