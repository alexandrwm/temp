using CafeApp.Models;

namespace CafeApp.FactoryMethod
{
    // Factory Method: Clasă de bază pentru creatori
    public abstract class DrinkCreator
    {
        public abstract Drink CreateDrink();
    }
}