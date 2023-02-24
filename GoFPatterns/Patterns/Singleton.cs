namespace GoFPatterns.Patterns
{
    // Creational 
    public class Singleton
    {
        // one instance per lifetime
        // if first time -> instantiated ; else take existing 
        private Singleton()
        {
        }

        private static Singleton instance;

        public static Singleton GetInstance() 
        {
            if (instance == null) 
            {
                instance = new Singleton();
            }
            return instance;
        }

        // configurational information 
        // di -> type must singleton 
    }
}
