using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine(circle1.Rad);
            Console.WriteLine(circle1.Area);

           
        }
    }
}
