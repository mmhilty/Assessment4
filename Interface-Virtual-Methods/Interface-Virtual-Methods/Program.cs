using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Virtual_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             This definitely uses single responsibility. Each method only 
             has one main purpose. Getter/setter, calculate area, etc.
             Means that the responsiblities are broken up enough.
             
             It also de facto uses the interface segregation principle because there
             are no chunks of the interface that we're forced to implement
             that aren't actually needed by the program. 
             
             
             
             */

        }
    }
}
