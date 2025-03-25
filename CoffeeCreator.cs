using CafeApp.Models;

namespace CafeApp.FactoryMethod
{
    // Creator concret pentru cafea
    public class CoffeeCreator : DrinkCreator
    {
        public override Drink CreateDrink()
        {
            return new Drink("Espresso");
        }
    }
}