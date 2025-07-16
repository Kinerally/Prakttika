using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин
{
    public class Tovar
    {
        public string Nazvanie;
        public int ID;
        public float Cena;
        public Tovar(string nasvanie, int id, float cena)
        {
            Nazvanie = nasvanie;
            ID = id;
            Cena = cena;
        }
    }
    public class Pokupatel
    {
        public string Name;
        public string Adres;
        public List<Tovar> Korzina;
        public Pokupatel(string name, string adres)
        {
            Name = name;
            Adres = adres;
            Korzina = new List<Tovar>();
        }

        public void AddToCart(Tovar tovar)
        {
            Korzina.Add(tovar);
        }
        public void Oformlenie()
        {
            if (Korzina.Count == 0)
            {
                Console.WriteLine("Ваша корзина пуста");
                return;
            }
            Console.WriteLine("\nОформление");
            Console.WriteLine($"Покупатель {Name}\nАдрес {Adres}\nТовары:");
            float Itog = 0;
            foreach (Tovar tovar in Korzina)
            {
                Console.WriteLine($"\t{tovar.Nazvanie} -- {tovar.Cena}P");
                Itog += tovar.Cena;
            }
            Console.WriteLine($"К оплате {Itog}");
        }
    }

}
