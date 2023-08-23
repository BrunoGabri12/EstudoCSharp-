
using System.Text.Json.Serialization;

namespace ScreenSound.Models
{
    internal class Music
    {
        [JsonPropertyName("song")]
        public string Nome { get; set; }

        [JsonPropertyName("artist")]
        public string Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        public void PrintInfos()
        {
             Console.WriteLine($"{Artista} + {Nome} + {Duracao} + {Genero}");
        }
    }
}
