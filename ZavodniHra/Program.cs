using System;

namespace ZavodniHra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Závodní hra!");
            // vytvoří seznam zavodniku
            List<Zavodnik> zavodnici = new List<Zavodnici>();
            // vytvoří závodníky a přidá je do seznamu
            zavodnici.Add(new Zavodnik());
            zavodnici.Add(new Zavodnik());
            zavodnici.Add(new Zavodnik());
            zavodnici.Add(new Zavodnik());

            // vytvoří dráhu
            Draha zavodniDraha = new Draha();
            ZavodniDraha.PrihlasiDoZavodu(zavodnici[0]);

            zavodniDraha.OdstartovatZavod();

        }
    }
}
