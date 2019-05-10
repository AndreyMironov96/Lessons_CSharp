using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            var penapple = new Penapple("Penapple", 50, 50);
            var eating = new Eating<Penapple>();
            
            eating.Add(penapple);
            var prod = new Product("Apple", 2, 56);
            var eating2 = new Eating<Product>();
            eating2.Add(prod);
            Console.ReadLine();
        }
    }
}
