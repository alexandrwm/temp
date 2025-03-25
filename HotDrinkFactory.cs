using CafeApp.Models;

namespace CafeApp.AbstractFactory
{
    // Fabrica pentru băuturi calde
    public class HotDrinkFactory : IDrinkFactory
    {
        public Drink CreateTea() => new Drink("Ceai cald");
        public Drink CreateCoffee() => new Drink("Cafea fierbinte");
    }
}