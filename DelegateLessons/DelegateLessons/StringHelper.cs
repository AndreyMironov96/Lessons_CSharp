using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLessons
{
    
    public delegate int CountDelegate(string message);
    class StringHelper
    {
            public void Message()
        {
            Console.WriteLine("ого, уже 71");
        }
    }
}
