namespace GoFPatterns.Patterns
{
    // structural 
    public class Composite
    {
        // tree strusture
        private List<Composite> children;

        public void AddChild(Composite composite) { children.Add(composite); }

        public bool IsIsolated() { return children.Count == 0; }
    }
}
