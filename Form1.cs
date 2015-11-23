using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //user: GuestABHS
    //pass: QaictCDbdqJxXnS
    public partial class GAForm : Form
    {                
        public GAForm()
        {
            InitializeComponent();
            Experiment.Display();
        }

        private void AllowIntegers(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void AllowDoubles(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            const char dec = (char)46;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != delete && e.KeyChar != dec;
        }

        private void DontAllow(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Population.Size = Convert.ToInt32(NumChromosomes.Text);
                Chromosome.Size = Convert.ToInt32(NumSubChromes.Text);
                Experiment.Generations = Convert.ToInt32(NumGenerations.Text);
                Sub_Chromosome.Length = Convert.ToInt32(SubChromeLength.Text);
                Chromosome.Length = Chromosome.Size * Sub_Chromosome.Length;
                Experiment.Crossover = Convert.ToDouble(CrossoverProbability.Text);
                Experiment.Mutation = Convert.ToDouble(MutationProbability.Text);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message); 
                }
            }
            
        }

    }
}
