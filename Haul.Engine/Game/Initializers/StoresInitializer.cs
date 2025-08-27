using Haul.Contracts.Models;
using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Game.Initializers
{
    public class StoresInitializer
    {
        public static void AddStores(GameState gameState)
        {
            var locations = gameState.Locations;

            locations["StarportTerminal"].Stores.Add("TrashStore", new()
            {
                IsEngaged = false,
                StoreInventory = new Dictionary<string, Inventory>
                {
                    { 
                      Commodity.ScrapMetal.Name,
                      Commodity.ScrapMetal.CreateInventory(15)
                    },

                },

            });
        }
    }
}
