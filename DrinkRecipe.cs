using CafeApp.Prototype;

namespace CafeApp.Prototype
{
    // Clasa care implementează Prototype
    public class DrinkRecipe : IDrinkPrototype
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public DrinkRecipe(string name, List<string> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public IDrinkPrototype Clone()
        {
            return new DrinkRecipe(Name + " (copie)", new List<string>(Ingredients));
        }
    }
}