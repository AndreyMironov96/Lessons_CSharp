using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLessons
{

    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            MovingEventArgs m = new MovingEventArgs();
            StringHelper h = new StringHelper();

            students.onCount += m.Message;
            students.onCount += h.Message;
            students.Move(15);
        }


    }
}
