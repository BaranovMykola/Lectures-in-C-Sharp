using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class GoodEventArgs : EventArgs
    {
        public string Message { get; private set; }
        public GoodEventArgs(string message)
        {
            Message = message;
        }
    }
}
