using CafeApp.Models;

namespace CafeApp.AbstractFactory
{
    // Fabrica pentru băuturi reci
    public class ColdDrinkFactory : IDrinkFactory
    {
        public Drink CreateTea() => new Drink("Ceai rece");
        public Drink CreateCoffee() => new Drink("Cafea cu gheață");
    }
}