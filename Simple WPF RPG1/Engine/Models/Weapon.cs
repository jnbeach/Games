using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : Item
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon (int itemId, string name, int price, int minDamage, int maxDamage) : base(itemId, name, price)
        {           
            this.Type = "Weapon";
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
        }

    }
}
