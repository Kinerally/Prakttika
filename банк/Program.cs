using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace банк
{
    class Program
    {
        static void Main(string[] args)
        {
            float Vklad;
            while (true)
            {
                Console.WriteLine("Введите сумму вклада");
                string vklad = Console.ReadLine();
                if (float.TryParse(vklad, out Vklad) && Vklad > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно!");
                }
            }
            float Mounth;
            while (true)
            {
                Console.WriteLine("Введите количество месяцев");
                string mounth = Console.ReadLine();
                if (float.TryParse(mounth, out Mounth) && Mounth >0)
                {
                    break;
                }
                else
                {
                        Console.WriteLine("Неверно!");
                }
                
            }
            for (int i = 1; i <= Mounth ; i++)
            {
             Vklad += Vklad * 7/100f;
            }
            Console.WriteLine($"Итого = {Vklad}");
        }
    }
}
