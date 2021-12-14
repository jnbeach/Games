using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Item
    {
        public int ItemId {get; set;}
        public string Name {get; set;}
        public int Price {get; set;}
        public string Type {get; set;}
        public Item (int itemID, string name, int price)
        {
            this.ItemId = itemID;
            this.Name = name;
            this.Price = price;
            this.Type = "Item";
        }
    }
}
