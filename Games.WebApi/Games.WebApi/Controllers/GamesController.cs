using Games.Core;
using Games.DB;
using Microsoft.AspNetCore.Mvc;

namespace Games.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        private IGamesServices _gamesServices;
        public GamesController(IGamesServices gamesServices)
        {
            _gamesServices = gamesServices;
        }

        [HttpGet]
        public IActionResult GetGames()
        {
            return Ok(_gamesServices.GetGames());
        }

        [HttpGet("{id}", Name = "GetGame")]
        public IActionResult GetGame(int id)
        {
            return Ok(_gamesServices.GetGame(id));
        }

        [HttpPost]
        public IActionResult CreateGame(Game game)
        {
            var newGame = _gamesServices.CreateGame(game);
            return CreatedAtRoute("GetGame", new { newGame.GameId }, newGame);
        }

        [HttpDelete]
        public IActionResult DeleteGame(Game game)
        {
            _gamesServices.DeleteGame(game);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditGame(Game game)
        {
            return Ok(_gamesServices.EditGame(game));
        }
    }
}
