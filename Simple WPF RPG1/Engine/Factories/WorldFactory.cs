using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

//This Factory class uses the World.AddLocation method in order to add Locations to a new instance of the World class. This prevents having to do this 100 times over in the GameSession.cs file for every location.
namespace Engine.Factories
{
    internal static class WorldFactory
    {
        /// <summary>
        /// Instantiates a new World object and uses the AddLocation method to add locations to the newly instantiated World.
        /// </summary>
        /// <returns>A World object with all locations populated.</returns>
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, 0, "Home", "This is your house.", "/Home.png");
            newWorld.AddLocation(1, 0, "Trail to the Shadow Forest", "A path winds across a fertile valley.", "/Home.png");
            newWorld.AddLocation(0, -1, "Southern Cave", "A cave silently overlooks the ocean below.", "/Home.png");
            newWorld.AddLocation(-1, 0, "Castle Town", "This is the Castle Town of FairWeather.", "/Home.png");
            newWorld.AddLocation(0, 1, "The Azure Plains", "Gentle sloping fields surround you.", "/Home.png");
            return newWorld;
        }
    }
}
