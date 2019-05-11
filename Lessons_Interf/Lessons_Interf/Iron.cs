using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Interf
{
    class Iron : IIron
    {
        public double Degree(int mode)
        {
            return mode * 50;
        }
    }
}
