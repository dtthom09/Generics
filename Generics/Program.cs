using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var ages = new List<int>();
            ages.Add(4);
            var p = new Program();
            p.ShowValue(3);
            p.ShowValue("wow");
            p.ShowValue('p');
            p.ShowValue(2.17);

            p.AddValues(3.1, 7);
            p.AddValues("4", "2");
            p.AddValues("13", 17);

            Multiply(2, 3);
            Multiply("3", 6.89);
        }

        public void ShowValue<T>(T value)
        {
            Console.WriteLine(value.ToString());
        }
        public void AddValues<D, T>(D first, T second)
        {
            var value = Convert.ToInt32(first) + Convert.ToInt32(second);
            Console.WriteLine(value.ToString());
        }
        public static void Multiply<x, y>(x first, y second)
        {
            var value = Convert.ToInt32(Convert.ToDouble(first) * Convert.ToDouble(second));
            Console.WriteLine(value.ToString());
        }
    }
}
