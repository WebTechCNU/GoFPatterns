namespace GoFPatterns.Patterns
{
    // Creational 
    public class Prototype
    {
        public Prototype(State state)
        {
            State = state;
        }

        public State State { get; set; }

        public Prototype GetPrototype() 
        {
            return new Prototype(State);
        }
    }

    public class State
    {
    }

    public class Usage 
    {
        public void Main() 
        {
            Prototype prototype = new Prototype(new State());
            var prototypeClone = prototype.GetPrototype();
        }
    }
}
