using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class FavoriteMusics
    {
        public string Name { get; set; }
        public List<Music> FavoriteMusicsList;

        public FavoriteMusics(string name) { 
            Name = name;
            FavoriteMusicsList = new List<Music>();
        }

        public void AddFavoriteMusics(Music music)
        {
            FavoriteMusicsList.Add(music); 
        }

        public void PrintFavoriteMusics()
        {
            FavoriteMusicsList.ForEach(music => Console.WriteLine($"{music.Nome} -- {music.Artista}"));
        }
    }
} 