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
        private List<List<List<int>>> CurrentGen;
        private List<List<List<int>>> NextGen;

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
            CurrentGen = new List<List<List<int>>>();

            for (int x = 0; x < Size; x++)
            {
                Chromosome chr = new Chromosome();
                CurrentGen.Add(chr.getChrome());
            }
        }

        public void Crossover()
        {
            //do what it says
        }

        public void CreateNextGen()
        {
            NextGen = new List<List<List<int>>>();

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
