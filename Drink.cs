namespace CafeApp.Models
{
    // Model de bază pentru băuturi
    public class Drink
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public Drink(string name)
        {
            Name = name;
            Ingredients = new List<string>();
        }
    }
}