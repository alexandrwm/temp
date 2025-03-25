using CafeApp.Models;

namespace CafeApp.Builder
{
    // Builder pentru băutură
    public class DrinkBuilder
    {
        private Drink _drink = new Drink("");

        public void Reset() => _drink = new Drink("");

        public void SetName(string name) => _drink.Name = name;

        public void AddIngredient(string ingredient) => _drink.Ingredients.Add(ingredient);

        public Drink GetDrink() => _drink;
    }
}