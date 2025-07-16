using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практтика
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обьявляем названия типам
            int Int1999;
            int Int1998;
            float Float5000;
            float Float5005;
            char CharA;
            char CharB;
            string StringD;
            string StringG;
            bool BoolT;
            bool BoolF;
            object Object111;
         Console.WriteLine("=====Test=====");
            //Присваиваем переменные (инициализируем)
            Int1999 = 1999;
            Int1998 = 1998;
            Float5000 = 5000;
            Float5005 = 5005;
            CharA = 'A';
            CharB = 'B';
            StringD = "DDD";
            StringG = "ggg";
            BoolT = true;
            BoolF = false;
            Object111= "Текст 404";
            //производим манипуляции с переменными
            int IntSUM = Int1998 + Int1999;
            int IntSUB = Int1999 - Int1998;
            int IntDIV = Int1999 / Int1998;
            int IntMUL = Int1999 * Int1998;
                Console.WriteLine(string.Format("Операции над int:\nСложение = {0}\nВычитание = {1}\nДеление = {2}\nУмножение = {3}", IntSUM, IntSUB, IntDIV, IntMUL));
         Console.WriteLine("==============================================");
            float FloatSUM = Float5005 + Float5000;
            float FloatSUB = Float5005 - Float5000;
            float FloatDIV = Float5005 / Float5000;
            float FloatMUL = Float5005 * Float5000;
                Console.WriteLine($"Операции над float:\nСложение = {FloatSUM}\nВычитание = {FloatSUB}\nДеление = {FloatDIV}\nУмножение = {FloatMUL}");
         Console.WriteLine("==============================================");
            object IFSUM = Float5005 + Int1999;
            object IFSUB = Float5000 - Int1998;
            object IFDIV = Float5005 / Int1999;
            object IFMUL = Float5000 * Int1998;
                Console.WriteLine($"Операции над int и float:\nСложение = {IFSUM}\nВычитание = {IFSUB}\nДеление = {IFDIV}\nУмножение = {IFMUL}");
            //операции над текстом
         Console.WriteLine("==============================================");
            Console.WriteLine("Операции над текстом:");
                string StringCON =string.Concat (StringD, StringG);
                Console.WriteLine(StringCON);
                Console.WriteLine("Прописные = {0}", StringD.ToLower());
                Console.WriteLine("Заглавные = {0}", StringG.ToUpper());
                Console.WriteLine("Длина = {0}", StringCON.Length);
                Console.WriteLine("Сравнение = {0}", StringD.Equals(StringG));
                Console.WriteLine("Замена = {0}", StringD.Replace("D", "A"));
                Console.WriteLine("Встраивание = {0}", StringCON.Insert(6, StringD));
            Console.WriteLine("==============================================");
                Console.WriteLine("Сложение слов = {0}", StringD + CharB);
                Console.WriteLine("Встраивание = {0}", StringCON.Insert(3, CharA.ToString()));
            Console.WriteLine("==============================================");
                Console.WriteLine("присвоение Default");
                int IntD = default;
                Console.WriteLine(IntD);
            Console.WriteLine("==============================================");
                Console.WriteLine("Присвоение New");
                float FloatN = new long();
                Console.WriteLine(FloatN);
            Console.WriteLine("==============================================");
                Console.WriteLine($" = {Object111 + StringCON.ToUpper()}");
                string ObjectS = Object111 as string;
                    if (ObjectS != null) 
                Console.WriteLine($"Преобразование = {ObjectS}"); //я думал что выдаст ошибку так как есть число
            Console.WriteLine("==============================================");
                int IntM = int.MaxValue;
                Console.WriteLine($"Максимальное значение = {IntM}");
            Console.WriteLine("==============================================");
                Console.WriteLine("Сравнение");
                Console.WriteLine($"1999 = 1998? = {Int1999 == Int1998}");
                Console.WriteLine($"5005 < 5000? = {Float5005 < Float5000}");
                Console.WriteLine($"%005 > 1999? = {Float5005 > Int1999}");
            Console.WriteLine("==============================================");
                long LongA = 777;
                string StringA = "ABS";
                int IntA = Convert.ToUInt16(LongA);
                Console.WriteLine($"Из long в int = {IntA}");
                bool IntB = int.TryParse(StringA, out int StringB);
                    if (IntB)
            {
                        Console.WriteLine($"Если число: {StringB}");
            }
                    else
            {
                        Console.WriteLine($"НЕВЫШЛО!!!!");
            }
            Console.WriteLine("==============================================");
                Console.WriteLine("Дата и время");
                DateTime Date = new DateTime();
                string DateN = string.Format("{0:yyyy.MM.dd HH:mm.ss fff}", DateTime.Now);
                Console.WriteLine("Дата = {0}", DateN);
                string TimeN = string.Format("{0:ss-fff}", DateTime.Now);
                Console.WriteLine("Время = {0}", TimeN);
            Console.WriteLine("==============================================");
                bool StringBool = StringD.Contains("D");
                Console.WriteLine($"Есть D? = {StringBool}");
            Console.WriteLine("==============================================");
                int Hash = StringCON.GetHashCode();
                Console.WriteLine($"ХешКод = {Hash}");
            Console.WriteLine("==============================================");
        }
    }
}
