using CafeApp.Models;

namespace CafeApp.AbstractFactory
{
    // Abstract Factory: Interfață pentru fabrici de băuturi
    public interface IDrinkFactory
    {
        Drink CreateTea();
        Drink CreateCoffee();
    }
}