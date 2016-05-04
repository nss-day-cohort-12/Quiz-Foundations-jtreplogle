using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Order
    {
        //Needs Dring + Entree + Dessert.
        public string Drink { get; set; }
        public string Entree { get; set; }
        public string Dessert { get; set; }


        public bool VerifyOrderComplete()
        {
            //If all stings (props of Order) are used ~ VerifyOrder ~ True.
            if (this.Drink != null && this.Entree != null && this.Dessert != null)
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
