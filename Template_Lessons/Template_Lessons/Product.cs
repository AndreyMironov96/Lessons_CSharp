using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Lessons
{
    public class Product
        
    {
        public string Name { get; }
        public double Volume { get; }
        public double Kalories { get; }
        public Product(string name, double volume, double kalories)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя продукта не может быть пустым");
            }
            Name = name;
            Volume = volume;
            Kalories = kalories;
          
            
        }
        public override string ToString()
        {
            return $"Название продукта {Name}, количество {Volume}, Калории {Kalories}";
        }
    }
}
