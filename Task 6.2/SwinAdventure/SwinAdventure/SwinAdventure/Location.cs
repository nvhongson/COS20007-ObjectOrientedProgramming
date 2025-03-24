using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SwinAdventure
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory;

        public Location(string name, string desc) : base(new string[] { "location" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public override string FullDesciption
        {
            get
            {
                return $"\nYou are at {Name}\nRoom Description: {base.FullDesciption}\n\nItems at this location:\n{Inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get => _inventory;
        }
    }
}
