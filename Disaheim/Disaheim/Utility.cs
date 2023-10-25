using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{

    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }


        public double GetValueOfAmulet(Amulet amulet)
        {
            //return Level type with different values 12.5, 20.0, 27.5
            if (amulet.Quality == Level.LOW)
            {
                return 12.5;
            }

            else if (amulet.Quality == Level.MEDIUM)
            {
                return 20.0;

            }

            else 
            { 
                return 27.5;
            }
        }
    }
}
