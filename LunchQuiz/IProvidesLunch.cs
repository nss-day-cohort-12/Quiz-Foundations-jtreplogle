using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    interface IProvidesLunch
    {
        //Create I for unique props KidsArea + Delivery
        bool hasKidsArea { get; set; }
        bool hasDelivery { get; set; }
    }
}
