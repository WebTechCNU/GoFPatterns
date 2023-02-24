using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFPatterns.Patterns
{
    // Creational
    public class AbstractFactory
    {
        // no intermediate state of constructed object
        // returns a familly of objects
    }


    public abstract class AbstractType { }

    public class TypeA : AbstractType { }
    public class TypeB : AbstractType { }
    public class TypeC : AbstractType { }

}

