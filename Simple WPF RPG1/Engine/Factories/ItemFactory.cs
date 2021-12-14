using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.ViewModels;

namespace Engine.Factories
{
    internal static class ItemFactory
    {
        //private static List<Item> _itemList;
        
        public static List<Item> CreateItemList()
        {
            List<Item> itemList = new List<Item>();
            itemList.Add(new Weapon(1, "Dagger", 1, 1, 2));
            itemList.Add(new Weapon(2, "Rapier", 5, 1, 3));
            return itemList;
        }

        /// <summary>
        /// Generates an item with the given ItemID from a list of Items. If the ItemID does not exist in the list, returns null.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="itemList"></param>
        /// <returns></returns>
        public static Item CreateItem(int itemId, ref List<Item> itemList)
        {
            
            Item standardItem = itemList.FirstOrDefault(item => item.ItemId == itemId);
            if (standardItem != null)
            {
                return standardItem;
            }
            return null;
        }
        //internal static Item CreateItem()
        //{
        //    Item newItem = new Item();


        //    return newItem;
        //}
    }
}
