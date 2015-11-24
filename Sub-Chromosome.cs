using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Sub_Chromosome
    {
        // repeat private static variable and public property for 
        //  consecutive ones and zeros 
        static private int subChromLength = 0;

        public static int Length
        {
            get
            {
                return subChromLength;
            }

            set
            {
                subChromLength = value;
            }
        }

        // constructor
        public Sub_Chromosome
        {
            // what should be done during creation of a single sub chromosome?   
        }
        }
    }
}
