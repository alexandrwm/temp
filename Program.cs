using CafeApp.Singleton;
using CafeApp.FactoryMethod;
using CafeApp.AbstractFactory;
using CafeApp.Prototype;
using CafeApp.Builder;
using CafeApp.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pattern-uri OOP în C# - Cafenea ===");

        // Singleton
        var manager = DrinkManager.Instance;
        manager.Log("Managerul cafenelei a fost instanțiat.");

        // Factory Method
        DrinkCreator teaCreator = new TeaCreator();
        Drink tea = teaCreator.CreateDrink();
        manager.Log($"Factory Method: Băutură creată - {tea.Name}");

        // Abstract Factory
        IDrinkFactory hotFactory = new HotDrinkFactory();
        Drink hotDrink = hotFactory.CreateTea();
        manager.Log($"Abstract Factory: Băutură caldă - {hotDrink.Name}");

        // Prototype
        var recipe = new DrinkRecipe("Cafea cu lapte", new List<string> { "Apă", "Cafea", "Lapte" });
        var clonedRecipe = recipe.Clone();
        manager.Log($"Prototype: Rețetă clonată - {clonedRecipe.Name}");

        // Builder
        var builder = new DrinkBuilder();
        var director = new Director(builder);
        director.BuildCoffee();
        Drink builtCoffee = builder.GetDrink();
        manager.Log($"Builder: Băutură construită - {builtCoffee.Name}");
    }
}