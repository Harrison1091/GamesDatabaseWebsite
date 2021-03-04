using Games.DB;
using Games.Core;
using System.Collections.Generic;
using System.Linq;

namespace Games.Core
{
    public class GamesServices : IGamesServices
    {
        private AppDbContext _context;

        public GamesServices(AppDbContext context)
        {
            _context = context;
        }

        public Game CreateGame(Game game)
        {
            _context.Add(game);
            _context.SaveChanges();

            return game;
        }

        public void DeleteGame(Game game)
        {
            _context.Games.Remove(game);
            _context.SaveChanges();
        }

        public Game EditGame(Game game)
        {
            var dbGame = _context.Games.First(e => e.GameId == game.GameId);
            dbGame.Description = game.Description;
            dbGame.ReleaseDate = game.ReleaseDate;
            dbGame.Name = game.Name;
            dbGame.Rating = game.Rating;
            dbGame.PEGIRating = game.PEGIRating;
            _context.SaveChanges();

            return dbGame;
        }

        public Game GetGame(int id)
        {
            return _context.Games.First(e => e.GameId == id);
        }

        public List<Game> GetGames()
        {
            return _context.Games.ToList();
        }
    }
}
