using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class EventProgram
    {
        static void Main(string[] args)
        {
            Shop market = new Shop();
            market.Goods = new List<Good>
            {
                new Good("Good1", 30),
                new Good("Good2", 300),
                new Good("Good3", 40)
            };
            market.OutputDiscount += Handler.HendlerMethod;
            market.isPriceSmall();
            //EvenHandle(obj sender, Event args)
            Console.ReadKey();
    }
}
}
