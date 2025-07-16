using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Дз2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================================");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите вашу профессию");
            string prof = Console.ReadLine();
            if (!int.TryParse(age, out int Iage))
            {
                Console.WriteLine("Это не является возрастом!");
            }
            if (Iage >= 20)
            {
                if (Iage % 2 == 0)
                {
                    Console.WriteLine($"Вас зовут {name}\nВам {Iage} года\nВаша профессия {prof}");
                }
                else
                {
                    Console.WriteLine($"Вас зовут {name}\nВам {Iage} лет\nВаша профессия {prof}");
                }
            }
            else
            {
                Console.WriteLine($"Вас зовут {name}\nВам {Iage} лет\nВаша профессия {prof}");
            }
            Console.WriteLine("========================================================================");
            int a = 20;
            Console.WriteLine(a);
            a = 50;
            Console.WriteLine(a);
            const int b = 40;
            Console.WriteLine(b);
            Console.WriteLine("========================================================================");
            var H = 123;
            var G = "Прривет";
            var J = 13.4;
            Console.WriteLine($"H = {H}\nG = {G}\nJ = {J}");
            H = 99;
            G = "Пока";
            J = (float)404.404d;
            Console.WriteLine($"H = {H}\nG = {G}\nJ = {J}");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Введите свой рост в сантиметрах");
            string Height = Console.ReadLine();
            Console.WriteLine("Введите свой вес");
            string Weight = Console.ReadLine();
            if (!float.TryParse(Height, out float Cheight))
            {
                Console.WriteLine("Введенный рост не является числом!");
            }
            if (!float.TryParse(Weight, out float weight))
            {
                Console.WriteLine("Введенный вес не является числом!");
            }
            float height = Cheight / 100;
            float IMT = weight / (height * height);

            switch (IMT)
            {
                case float aaa when IMT < 20:
                    Console.WriteLine($"Ваш ИМТ = {IMT}\nУ вас недовес");
                    break;
                case float bbb when (IMT >= 20 && IMT <= 25):
                    Console.WriteLine($"Ваш ИМТ = {IMT}\nВаш вес в норме");
                    break;
                case float ccc when (IMT >= 25 && IMT <= 30):
                    Console.WriteLine($"Ваш ИМТ = {IMT}\nУ вас избыточный вес");
                    break;
                case float ddd when (IMT >= 30 && IMT <= 40):
                    Console.WriteLine($"Ваш ИМТ = {IMT}\nУ вас ожирение");
                    break;
                case float eee when IMT > 40:
                    Console.WriteLine($"Ваш ИМТ = {IMT}\nУ вас тяжелое ожирение");
                    break;
            }
            Console.WriteLine("========================================================================");
            int n = 5;
            int t = ++n + 5;
            int k = --n + 5;
            int l = n++ + 5;
            int z = n-- + 5;
            Console.WriteLine($"{n}\n{t}\n{k}\n{l}\n{z}");
            Console.WriteLine("========================================================================");
            int u = 8;
            u += 5;
            int y = 200;
            y -= 133;
            int r = 66;
            r *= 2;
            Console.WriteLine($"{u}\n{y}\n{r}");
            Console.WriteLine("========================================================================");
            int g = 154;
            int f = 23;
            float m = (float)f / g;
            Console.WriteLine(m);
            Console.WriteLine("========================================================================");
            Console.WriteLine("Введите первое число");
            string p = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string v = Console.ReadLine();
            if (!float.TryParse(p, out float P))
            {
                Console.WriteLine("Это не является числом");
            }
            if (!float.TryParse(v, out float V))
            {
                Console.WriteLine("Это не является числом");
            }
            if (P == V)
            {
                Console.WriteLine($"Число {P} равно числу {V}");
            }
            else if (P > V)
            {
                Console.WriteLine($"Число {P} больше числа {V}");
            }
            else
            {
                Console.WriteLine($"Число {P} меньше числа {V}");
            }
            const float GG = 0.001f;
            Console.WriteLine("========================================================================");
            Console.WriteLine("Введите число");
            string w = Console.ReadLine();
            if (float.TryParse(w, out float W))
            {
                if (W > 5 && W < 10)
                {
                    Console.WriteLine("Число больше 5 и меньше 10");
                }
                else
                {
                    Console.WriteLine("Неизвестное число");
                }
            }
            else
            {
                Console.WriteLine("Это не является числом");
            }
            Console.WriteLine("========================================================================");
            Console.WriteLine("Введите 3 числа");
            string Pervoe = Console.ReadLine();
            string Vtoroe = Console.ReadLine();
            string Tretie = Console.ReadLine();
            if (!float.TryParse(Pervoe, out float pervoe))
            {
                Console.WriteLine("Это не является числом");
            }
            if (!float.TryParse(Vtoroe, out float vtoroe))
            {
                Console.WriteLine("Это не является числом");
            }
            if (!float.TryParse(Tretie, out float tretie))
            {
                Console.WriteLine("Это не является числом");
            }
            float Itog = (pervoe + vtoroe + tretie) / 3;
            Console.WriteLine($"Итог {Itog}");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Введите 3 числа");
            string Chetvertoe = Console.ReadLine();
            string Patoe = Console.ReadLine();
            string Shestoe = Console.ReadLine();
            if (!float.TryParse(Chetvertoe, out float chetvertoe))
            { 
                Console.WriteLine("Это не является числом");
            }
            if(!float.TryParse(Patoe, out float patoe))
            { 
                Console.WriteLine("Это не является числом"); 
            }
            if(!float.TryParse(Shestoe, out float shestoe))
            {
                Console.WriteLine("Это не является числом");
            }
            if ((chetvertoe >= patoe && chetvertoe <= shestoe) || (chetvertoe <= patoe && chetvertoe >= shestoe))
            {
                Console.WriteLine($"Среднее = {chetvertoe}");
            }
            else if ((patoe >= chetvertoe && patoe <= shestoe) || (patoe <= chetvertoe && patoe >= shestoe))
            {
                Console.WriteLine($"Среднее = {patoe}");
            }
            else
            {
                Console.WriteLine($"Среднее = {shestoe}");
            }
        }
    }
}
