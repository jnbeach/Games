using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    //Each Location has a Name, Description, Coordinates, and an Image associated with it.
    public class Location
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
    }
}
