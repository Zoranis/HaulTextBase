using HaulTextBase.Game;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Persistence
{
    public interface IPersistenceService
    {
        public void SaveGame(GameState gameState);
        public GameState LoadGame();
    }
}
