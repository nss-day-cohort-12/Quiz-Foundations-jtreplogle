using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Customer
    {
        public bool ReadyToPlaceOrder(Order order, Restaurant restaurant)
        {
            //Have a complete Order: Drink + Entree + Dessert = Complete.
            //Can't use || cahrs.
            if (restaurant.ItemIsOnMenu(order.Drink) && restaurant.ItemIsOnMenu(order.Entree) && restaurant.ItemIsOnMenu(order.Dessert) && order.VerifyOrderComplete())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
