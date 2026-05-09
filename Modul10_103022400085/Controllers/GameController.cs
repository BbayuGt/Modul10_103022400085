using Microsoft.AspNetCore.Mvc;

namespace Modul10_103022400085.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game>
        {
            new Game
            {
                Id = 1,
                Nama = "Valorant",
                Developer = "Riot Games",
                TahunRilis = 2020,
                Genre = "FPS",
                Rating = 8.5,
                Platform = new[] { "PC" },
                Mode = new[] { "Multiplayer" },
                IsOnline = true,
                Harga = 0
            },
            new Game
            {
                Id = 2,
                Nama = "GTA V",
                Developer = "Rockstar Games",
                TahunRilis = 2013,
                Genre = "Open World",
                Rating = 9.5,
                Platform = new[] { "PC", "PS4", "PS5", "Xbox"},
                Mode = new[] {"Singleplayer", "Multiplayer"},
                IsOnline = true,
                Harga = 300000
            },
            new Game
            {
                Id = 3,
                Nama = "The Witcher 3",
                Developer = "CD Projekt Red",
                TahunRilis = 2015,
                Genre = "RPG",
                Rating = 9.7,
                Platform = new[] { "PC", "PS4", "PS5", "Xbox", "Switch"},
                Mode = new[] {"Singleplayer"},
                IsOnline = false,
                Harga = 250000
            }
        };

        [HttpGet(Name = "/api/GetGame")]
        public List<Game> Get()
        {
            return games;
        }

        [HttpPost(Name = "/api/PostGame")]
        public Game PostGame(Game game)
        {
            games.Add(game);
            return game;
        }

        [HttpGet("{id}", Name = "/api/game/id")]
        public Game GetGameId(int id)
        {
            foreach (var item in games)
            {
                if (item.Id == id) return item;
            }
            return null;
        }

        [HttpPut("{id}", Name = "Put")]
        public void putGame(int id, Game game)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Id == id)
                {
                    games[i] = game;
                    return;
                }
            }
            return;
        }

        [HttpDelete(Name = "Delete")]
        public void deleteGame(int id)
        {
            foreach (var item in games)
            {
                if (item.Id == id)
                {
                    games.Remove(item);
                    break;
                }
            }
        }
    }
}
