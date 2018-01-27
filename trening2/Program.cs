using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace trening2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Skladnik pieczarka = new Skladnik("Pieczarki", 1.20);
            //List<Skladnik> pizza = new List<Skladnik>();
            //pizza.Add(new Skladnik("ser", 1.50));
            //pizza.Add(new Skladnik("Szynka", 2.50));
            //pizza.Add(new Sos("Czosnkowy", 3));
            //pizza.Add(pieczarka);
            //pizza.Add(new Skladnik("Papryka", 2.00));
            //foreach(var element in pizza)
            //{
            //    Console.WriteLine(element);
            //}
            //Console.ReadKey();
            //pizza.Sort((x, y) => y.PobierzCene().CompareTo(x.PobierzCene()));
            //foreach (var element in pizza)
            //{
            //    if (pizza.IndexOf(element) % 2 == 0)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}
            //Console.ReadKey();
            //pizza.Reverse();

            //tryas
            //{
            //    Skladnik x = new Skladnik("x")
            //}
            Queue<Zamowienie> zamówienia = new Queue<Zamowienie>();
            zamówienia.Enqueue(new NaMiejscu());
            zamówienia.Enqueue(new NaWynos());
            zamówienia.Enqueue(new NaWynos());
            foreach (var element in zamówienia)
            {
                element.UstawCzasDostawy("jutro");

            }
            zamówienia.Enqueue(new NaWynos());
            zamówienia.Enqueue(new NaWynos());
            foreach (var element in zamówienia)
            {
                element.UstawCzasDostawy("dziś");
            }
            foreach (var element in zamówienia)
            {
                Console.WriteLine(element.PoprawnyCzas());
            }
            Console.ReadKey();
            zamówienia.Clear();
        }
    }
}
