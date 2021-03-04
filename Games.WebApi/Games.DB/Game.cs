using System;
using System.ComponentModel.DataAnnotations;

namespace Games.DB
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public int Rating { get; set; }
        public int PEGIRating { get; set; }
    }
}
