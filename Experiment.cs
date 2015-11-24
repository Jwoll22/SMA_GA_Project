using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Experiment
    {
        static private int numGen = 0;
        static private double crossProb = 0.0;
        static private double mutateProb = 0.0;

        public static int NumGenerations
        {
            get
            {
                return numGen;
            }

            set
            {
                numGen = value;
            }
        }

        public static double Crossover
        {
            get
            {
                return crossProb;
            }

            set
            {
                crossProb = value;
            }
        }

        public static double Mutation
        {
            get
            {
                return mutateProb;
            }

            set
            {
                mutateProb = value;
            }
        }

        // Discuss this
        public static void CrossSelect()
        {
            Random n = new Random();

            if (n.NextDouble() < (Crossover/(double)100))
            {
                //crossover sub-chromosomes
            }
        }

        // Discuss this
        public static void MutateSelect()
        {
            Random n = new Random();

            if (n.NextDouble() < (Mutation/(double)100))
            {
                //do shift/switch for one sub-chromosome
            }
        }

        // disucss this
        public static void Run()
        {
            Population p = new Population();

            for (int x = 0; x < Generations; x++)
            {
                p.Crossover();
                p.CreateNextGen();
                p.ReplaceCurrentGen();
            }
        }

        public static void Display()
        {
            Population p = new Population();

            foreach (var Chrome in p.getGen())
            {
                foreach (var SubChrome in Chrome)
                {
                    foreach (var value in SubChrome)
                    {
                        Console.Write(value + " ");
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }

    }
}
