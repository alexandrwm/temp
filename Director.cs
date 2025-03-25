namespace CafeApp.Builder
{
    // Director: ghidează procesul de construire a băuturii
    public class Director
    {
        private readonly DrinkBuilder _builder;

        public Director(DrinkBuilder builder)
        {
            _builder = builder;
        }

        public void BuildCoffee()
        {
            _builder.Reset();
            _builder.SetName("Cafea personalizată");
            _builder.AddIngredient("Apă");
            _builder.AddIngredient("Cafea măcinată");
            _builder.AddIngredient("Zahăr");
        }
    }
}