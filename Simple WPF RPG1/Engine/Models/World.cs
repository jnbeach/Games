using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    //The World Class really only has a List Property called _locations that holds a list of Location objects. Rather than repeatedly instantiate 100 different locations in the GameSession, it is more effective to make a function here that instantiates each location and adds it to the list of locations (_locations)
    public class World
    {
        private List<Location> _locations = new List<Location>();

        /// <summary>
        /// Adds a location to the field _locations which is a List of Locations in the World.
        /// </summary>
        /// <param name="xCoord"></param>
        /// <param name="yCoord"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="imageFile"></param>
        internal void AddLocation(int xCoord, int yCoord, string name, string description, string imageFile)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoord;
            loc.YCoordinate = yCoord;
            loc.Name = name;
            loc.Description = description;
            loc.ImageFile = imageFile;

            _locations.Add(loc);
        }
        /// <summary>
        /// Given a set of X and Y coordinates, returns the Location object from the _locations field that matches the coordinate.
        /// </summary>
        /// <param name="xCoord"></param>
        /// <param name="yCoord"></param>
        /// <returns></returns>
        public Location LocationAt (int xCoord, int yCoord)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == xCoord && loc.YCoordinate == yCoord)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
