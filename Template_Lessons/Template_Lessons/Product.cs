using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Lessons
{
    class Product<T>
    {
        public string Name { get; }
        public double Volume { get; }
        public double Kalories { get; }
        public Product(string name, double volume, double kalories)
        {

        }
    }
}
