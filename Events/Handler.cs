using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Handler
    {
        public static void HendlerMethod(object sender, EventArgs args)
        {
            Console.WriteLine((args as GoodEventArgs)?.Message);
        }
    }
}
