using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Свойства
{
    class Person
    {
        string name = "Иван";
        public string Name
        {
            get { return name; }
        } 
    }
    class Temperature
    {
        double celsius;
        const double min = -273.15;
        public double Celsius
        {
            get
            {
                return celsius;
            }
            set
            {
                if (value < min)
                {
                    Console.WriteLine("Температура не должна быть ниже -273.15°C");
                }
                else
                {
                    celsius = value;
                }
            }

        }
    }
    public class Circle
    {
        public double Area => Math.PI * (2 * Rad);
        public double Rad { get; }
        public Circle (double rad)
        {
            Rad = rad;
        }
    }
    public class Vehicle
    {
        public double Speed { get; protected set; }
    }
    public class Car : Vehicle
    {
        public void Gaz(double gaz)
        {
            Speed += gaz;
        }
    }
    public class Counter
    {
        public static int InstanceCounter { get; private set; }
        public Counter ()
        {
            InstanceCounter ++;
        }
    }
}
