using Games.DB;
using System.Collections.Generic;

namespace Games.Core
{
    public interface IGamesServices
    {
        List<Game> GetGames();
        Game GetGame(int id);
        Game CreateGame(Game game);
        void DeleteGame(Game game);
        Game EditGame(Game game);
    }
}
