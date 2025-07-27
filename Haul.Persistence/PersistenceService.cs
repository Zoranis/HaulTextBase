using Haul.Contracts.Interfaces;
using Haul.Contracts.Models;
using Hauler.Contracts.Models;
using LiteDB;
using System.Diagnostics;

namespace Haul.Persistence
{
    public class PersistenceService
    {
        public void init()
        {
            // create a string that refers to the folder where the app is installed
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path += "\\Haul.db";
            //write path to output console
            Debug.WriteLine($"Database path: {path}");
            using (var db = new LiteDatabase(path))
            {
                var col = db.GetCollection<Location>("Locations");

                Location Location = new()
                {
                    Name = "Test Location",
                    Title = "Test Location Title",
                    Description = "This is a test location for the Haul application.",
                    Interactables = new List<Interactable>
                    {
                        new Interactable(), // Add interactables as needed
                        new Interactable()
                    },
                    Items = new List<Item>
                    {
                        new Item { Name = "Test Item 1" },
                        new Item { Name = "Test Item 2" }
                    }
                };

                // Insert new customer document (Id will be auto-incremented)
                col.Insert(Location);
            }
        }
    }
}
