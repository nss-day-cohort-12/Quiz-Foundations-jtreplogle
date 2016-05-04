using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FineDining : Restaurant, IProvidesDinner
    {
        //Needs: #ofSeats + #ofPrivateTables + openSunday.
        public int NumberofSeatsAtBar { get; set; }
        public int numberOfPrivateTables { get; set; }
        public bool openSunday { get; set; }

        //6x4 Person + 8x2 Person ~~+ 12@Bar From Restaurant.
        public override int capacity()
        {
            return base.capacity() + this.NumberofSeatsAtBar;
        }
    }
}
