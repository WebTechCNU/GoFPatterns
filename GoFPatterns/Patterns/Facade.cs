namespace GoFPatterns.Patterns
{
    // sctructural
    public class Facade
    {
        private ComplicatedSystem _system;
        public void UseSystem() 
        {
            // condition -> _system.GetA() etc.
        }
    }

    public class ComplicatedSystem 
    {
        public void GetA() { }
        public void GetB() { }
        public void GetC() { }
        public void GetD() { }
        public void GetE() { }

    }
}
