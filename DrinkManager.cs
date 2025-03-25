namespace CafeApp.Singleton
{
    // Singleton: asigură o singură instanță a managerului de băuturi
    public class DrinkManager
    {
        private static DrinkManager _instance;
        private DrinkManager() { }

        public static DrinkManager Instance => _instance ??= new DrinkManager();

        public void Log(string message)
        {
            Console.WriteLine("[DrinkManager] " + message);
        }
    }
}