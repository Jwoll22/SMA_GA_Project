using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Chromosome
    {
        static private int chromLength = 0;
        static private int numSubChrom = 0;
        private List<List<int>> Chrome;
        private List<int> SubChrome;

        public static int Length
        {
            get
            {
                return chromLength;
            }

            set
            {
                chromLength = value;
            }
        }

        public static int Size //# of sub-chromosomes
        {
            get
            {
                return numSubChrom;
            }

            set
            {
                numSubChrom = value;
            }
        }

        public Chromosome() //initialize
        {
            Random n = new Random();
            Chrome = new List<List<int>>();
            
            for (int x = 0; x < Size; x++)
            {
                SubChrome = new List<int>();
                int gene = (int)n.NextDouble();

                for (int y = 0; y < Sub_Chromosome.Length; y++)
                {
                    SubChrome.Add(gene);
                }

                Chrome.Add(SubChrome);
            }
        }

        public static void AckleysFunction()
        {
            //hold the binary-to-decimal, domain mapping, and actual function
        }

        public static void BoothsFunction()
        {
            //hold the binary-to-decimal, domain mapping, and actual function
        }

        public static void BulkinFunction()
        {
            //hold the binary-to-decimal, domain mapping, and actual function
        }

        public static void TimeSlotAllocation()
        {
            //no idea yet
        }

        public List<List<int>> getChrome()
        {
            return Chrome;
        }
    }
}
