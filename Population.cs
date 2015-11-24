using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Population
    {
        static private int popSize = 0;
        private List<Chromosome> currentGen;
        private List<Chromosome> nextGen;

        public static int Size
        {
            get
            {
                return popSize;
            }

            set
            {
                popSize = value;
            }
        }

        public Population() //intialize
        {
            // CurrentGen = new List<List<List<int>>>();  *update*

            for (int i = 0; i < Size; i++)
            {
                Chromosome chr = new Chromosome();
                CurrentGen.Add(chr);
            }
        }

        public void Crossover()
        {
            //do what it says
        }

        public void CreateNextGen()
        {
            // NextGen = new List<List<List<int>>>(); *update*

        }

        public void ReplaceCurrentGen()
        {
            CurrentGen = NextGen;
        }
        
        public List<List<List<int>>> getGen()
        {
            return CurrentGen;
        }
    }
}
