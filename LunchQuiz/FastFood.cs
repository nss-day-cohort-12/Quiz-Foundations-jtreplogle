using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FastFood : Restaurant, IProvidesLunch
    {
        //Needs: DriveThrough + KidsArea + Delivery
        public bool HasDriveThrough { get; set; }
        public bool hasKidsArea { get; set; }
        public bool hasDelivery { get; set; }

        public void addMenuItem(string foodItem)
        {
            MenuItem newMenuItem = new MenuItem();
            newMenuItem.Name = foodItem;
            this.MenuItems.Add(newMenuItem);
        }

        public void addMenuItem(string foodItem, double foodPrice)
        {
            MenuItem newMenuItem = new MenuItem();
            newMenuItem.Name = foodItem;
            newMenuItem.Price = foodPrice;
            this.MenuItems.Add(newMenuItem);
        }
    }
}
