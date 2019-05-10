using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLessons
{
    class MovingEventArgs:EventArgs
    {
        public void Message()
        {
            Console.WriteLine("и правда 71");
        }
    }
}
