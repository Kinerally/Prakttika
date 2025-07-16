using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вклад
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================================");
            Console.WriteLine("Введите ваш вклад");
            string Vklad = Console.ReadLine();
            if (!float.TryParse(Vklad, out float vklad))
            { 
                Console.WriteLine("Это не является числом");
            }
            float proc =0;
            switch (vklad)
            {
                case float A when vklad < 100:
                    proc = vklad / 100 * 5;
                    break;
                case float B when (vklad >= 100 && vklad <= 200):
                     proc = vklad / 100 * 7;
                    break;
                case float C when vklad > 200:
                    proc = vklad / 100 * 10;
                    break;
            }
            float a = vklad + proc;
            Console.WriteLine($"Вы получите {a}");
        }
    }
}
