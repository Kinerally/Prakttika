using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Дз3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================2==========================");
            Console.WriteLine("Таблица умножения");
            for (int i = 1; i <= 10; i++)
            {
                for (int v = 1; v <= 10; v++)
                {
                    Console.Write($"{i * v,12}");
                }
            }
            Console.WriteLine("=============================3==========================");
            Console.WriteLine("Введите 5 чисел");
            int one;
            int two;
            int three;
            int four;
            int five;
            if (!int.TryParse(Console.ReadLine(), out one))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out two))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out three))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out four))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out five))
            {
                Console.WriteLine("Error");
            }
            int[] massive = { one, two, three, four, five };
            int min = massive[0];
            int max = massive[0];
            for (int i = 1; i < massive.Length; i++)
            {
                if (massive[i] < min)
                {
                    min = massive[i];
                }
                if (massive[i] > max)
                {
                    max = massive[i];
                }

            }
            Console.WriteLine($"Min = {min}\nMax = {max}");
            Console.WriteLine("=============================4==========================");
            Console.WriteLine("Введите 6 чисел");
            int un;
            int deux;
            int trois;
            int quatre;
            int cinq;
            int six;
            if (!int.TryParse(Console.ReadLine(), out un))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out deux))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out trois))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out quatre))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out cinq))
            {
                Console.WriteLine("Error");
            }
            if (!int.TryParse(Console.ReadLine(), out six))
            {
                Console.WriteLine("Error");
            }
            int[] numbers1 = { un, deux, trois };
            int[] numbers2 = { quatre, cinq, six };
            var ravenstvo = numbers1.Intersect(numbers2).ToArray();
            int peresecheniya = ravenstvo.Count();
            Console.WriteLine($"количество пересечений {peresecheniya}");
            Console.WriteLine("=============================5==========================");
            Console.WriteLine("веедите имя");
            string uname = Console.ReadLine();
            UserPrivet(uname);
            Console.WriteLine("============================6===========================");
            int chislo;
            Console.WriteLine("Введите число для получения его квадрата");
            if (!int.TryParse(Console.ReadLine(), out chislo))
            {
                Console.WriteLine("Error");
            }
            KvadratChisla(chislo);
            Console.WriteLine("============================7===========================");
            Console.WriteLine("Веедите ваш рост");
            if (int.TryParse(Console.ReadLine(), out int rost))
            {
                ProverkaDostupa(rost);
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("===========================8============================");
            int[] naborchisel = { 30, 22, 18, 40 };
            int maxchislo = PoiskMax(naborchisel);
            Console.WriteLine($"Максимальное число в массиве {maxchislo}");
            Console.WriteLine("===========================9============================");
            Pogoda(VremaGoga.Zima);
            Pogoda(VremaGoga.Vesna);
            Pogoda(VremaGoga.Leto);
            Pogoda(VremaGoga.Osen);

        }
        static void UserPrivet(string name) //задание 5
        {
            Console.WriteLine($"Привет {name}!");
        }
        static void KvadratChisla(int kvadrat) //задание 6
        {
            kvadrat *= kvadrat;
            Console.WriteLine($"Квадрат = {kvadrat}");
        }
        const int MINH = 150;
        static bool ProverkaRosta(int rost) //задание 7
        {
            return rost > MINH;
        }
        static void ProverkaDostupa(int rost)
        {
            if (ProverkaRosta(rost))
            {
                Console.WriteLine("Добро пожаловать!");
            }
            else
            {
                Console.WriteLine("Прощате, вы карлик");
            }
        }
        static int PoiskMax(int[] chisla) //задание 8
        {
            int max = chisla[0];
            for (int i = 1; i < chisla.Length; i++)
            {
                if (chisla[i] > max)
                {
                    max = chisla[i];
                }
            }
            return max;
        }
       public enum VremaGoga //задание 9 
        {
            Zima,
            Vesna,
            Leto,
            Osen
        }
       public static void Pogoda(VremaGoga season)
        {
            switch(season)
            {
                case VremaGoga.Zima:
                    Console.WriteLine("\tЗимой холодно и падает снег");
                    break;
                case VremaGoga.Vesna:
                    Console.WriteLine("\tВесной температура больше 0, происходит цветение и льют дожди");
                    break;
                case VremaGoga.Leto:
                    Console.WriteLine("\tЛетом тепло, большую часть дня светит солнце и возможны грозы");
                    break;
                case VremaGoga.Osen:
                    Console.WriteLine("\tОсенью становится холоднее, все желтеет и опадает и льют ");
                    break;
                default:
                    Console.WriteLine("\tЭто что за время года!?");
                    break;
            }
        }
    }
}
