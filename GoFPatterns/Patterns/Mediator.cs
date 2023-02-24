namespace GoFPatterns.Patterns
{
    // Behavioral 
    // low coupling
    public class Mediator
    {

        // typeA <-> Mediator <-> typeB = low coupling
        private MessagerB _messager;

        internal void Send(Type type, string v)
        {
            if (type == typeof(MessagerB)) { _messager.Receive(v); }
        }
    }

    public class MessagerA 
    {
        private Mediator _mediator;
        public void Send() 
        {
            _mediator.Send(typeof(MessagerB), "hello");
        }
        public void Receive() { }

    }

    public class MessagerB 
    {
        public void Send() { }
        public void Receive(string s) { }
    }

}
