using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    interface IProvidesDinner
    {
        //Create I for unique props #ofTables and Is OpenSunday?        
        int numberOfPrivateTables { get; set; }
        bool openSunday { get; set; }
    }
}
