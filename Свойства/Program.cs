using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Свойства
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ivan = new Person();
            //Ivan.Name = "не иван"; Невозможно. Доступ только для чтения!
            Console.WriteLine(Ivan.Name);

            Temperature Temp = new Temperature();
            Temp.Celsius = 33;
            Console.WriteLine(Temp.Celsius);
            Temp.Celsius = -300;
            Console.WriteLine(Temp.Celsius);

            Circle circle1 = new Circle(12);
            Console.WriteLine($"Радиус {circle1.Rad}");
            Console.WriteLine($"Площать {circle1.Area}");

            Vehicle vehicle1 = new Vehicle();
            //vehicle1.Speed = 200;
            Car car1 = new Car();
            car1.Gaz(200);
            Console.WriteLine($"Скорость машины = {car1.Speed}");

            Counter Count1 = new Counter();
            Console.WriteLine($"Число = {Counter.InstanceCounter}");
            Counter Count2 = new Counter();
            Console.WriteLine($"Число = {Counter.InstanceCounter}");
        }
    }
}
