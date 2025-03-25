using CafeApp.Models;

namespace CafeApp.FactoryMethod
{
    // Creator concret pentru ceai
    public class TeaCreator : DrinkCreator
    {
        public override Drink CreateDrink()
        {
            return new Drink("Ceai verde");
        }
    }
}