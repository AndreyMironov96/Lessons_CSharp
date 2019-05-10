using System;


namespace Template_Lessons
{
    public class Eating<T>
        where T:Product
    {
        public double Volume { get; private set; }
        public void Add(T product)
        {
            Volume += product.Volume * product.Kalories;
            Console.WriteLine(Volume.ToString());
        }
    }
}
