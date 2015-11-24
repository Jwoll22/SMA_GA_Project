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
        // private List<List<int>> Chrome;    *Move to Population.cs* The list of Chromosomes IS the population
        public List<int> SubChrome;

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

        // We will discuss the constructor
        public Chromosome() //initialize
        {
            Random n = new Random();
            // Chrome = new List<List<int>>(); *Remove* A list of chromosomes is a population
            
            for (int i = 0; i < Size; i++)
            {
                SubChrome = new List<int>();
                int gene = (int)n.NextDouble();

                for (int j = 0; j < Sub_Chromosome.Length; j++)
                {
                    SubChrome.Add(gene);
                }

                Chrome.Add(SubChrome);
            }
        }
        
        public double AddOnesFitness()
        {
            // calculate fitness by adding all the ones in a chromosome
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

        public List<List<int>> GetChrome()
        {
            return Chrome;
        }
    }
}
