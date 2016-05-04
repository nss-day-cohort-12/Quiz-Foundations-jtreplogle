using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Casual : Restaurant
    {      
        public Casual()
        {
            //Create new instance of MenuItem/Pizza
            MenuItem Pizza = new MenuItem();
            //Add Pizza to MenuItems
            this.MenuItems.Add(Pizza);
        }
        public bool HasPatio { get; set; }
        public bool hasDelivery { get; set; }
        public bool hasKidsArea { get; set; }
    }
}

