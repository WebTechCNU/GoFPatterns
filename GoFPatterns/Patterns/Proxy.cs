namespace GoFPatterns.Patterns
{
    // structural
    public class Proxy : AbstractApi
    {
        // replacement object

        private ConcreteApi concreteApi = new ConcreteApi();

        public override void HandleRequest()
        {
            // check request 
            // wait 
            // check is online
            // orm 
            concreteApi.HandleRequest();
        }
    }

    public abstract class AbstractApi 
    {
        public abstract void HandleRequest();
    }

    public class ConcreteApi : AbstractApi
    {
        public override void HandleRequest()
        {
        }
    }


}
