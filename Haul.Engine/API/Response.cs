using HaulTextBase.Game;

namespace Haul.Engine.API
{
    public class Response
    {
        public GameState? GameState { get; set; }
        public string description { get; set; }
        public Response(GameState newGameState)
        {
            GameState = newGameState;
        }
    }
}
