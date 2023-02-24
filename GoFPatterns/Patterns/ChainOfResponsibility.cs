using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFPatterns.Patterns
{
    // Behavioral pattern
    public class ChainOfResponsibility
    {
        // chain -> request 

        // request --- handler1 -> handler2 -> handler3 -> handler4
        // low coupling 

        public ChainOfResponsibility Successor { get; set; }
        

        public void HandleReqeust(Request request) 
        {
            if (request.Condition)
            {
                Process(request);
            }
            else 
            {
                Successor.HandleReqeust(request);
            }
        }

        public void Process(Request request) { }
    }

    public class Request
    {
        public bool Condition;
    }
}
