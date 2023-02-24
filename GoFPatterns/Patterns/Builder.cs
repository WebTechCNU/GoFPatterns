namespace GoFPatterns.Patterns
{
    // Creational 
    public class Builder
    {
        public Builder()
        {
            Constructed = new Constructed();
        }

        // incapsulates creation of certain object
        public Constructed Constructed { get; set; }

        public void BuildPartA() 
        {
            Constructed.Items.Add(new Item());
        }

        public void BuildPartB() 
        { 
            Constructed.Items.Add(new Item());

        }


        public void BuildPartC() 
        { 
            Constructed.Items.Add(new Item());

        }

        public Constructed GetConstructed() { return Constructed; }

    }

    public class Constructed 
    {
        public List<Item> Items { get; set; }
    }

    public class Item
    {
    }
}
