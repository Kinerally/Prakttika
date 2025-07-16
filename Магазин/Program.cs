using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Магазин
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar svch = new Tovar("Микроволновка", 111, 15000);
            Tovar chaynic = new Tovar("Чайник", 222, 2300);
            Tovar holod = new Tovar("Холодильник", 333, 34000);
            //Покупатели
            Pokupatel petr = new Pokupatel("Петр Иванов", "г. Нижнекамск, ул. Пушкина, д. 44");
            Pokupatel oleg = new Pokupatel("Олег Пройдох", "г. Омск, ул. Попова, д. 2, к. 1");
            Pokupatel fil = new Pokupatel("Фил Ричардс", "г. Москва");

            petr.AddToCart(svch);
            petr.AddToCart(holod);
            oleg.AddToCart(svch);
            oleg.AddToCart(chaynic);
            oleg.AddToCart(holod);
            fil.AddToCart(chaynic);

            petr.Oformlenie();
            oleg.Oformlenie();
            fil.Oformlenie();
        }
    }
}
