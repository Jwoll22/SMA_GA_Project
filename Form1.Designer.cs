namespace WindowsFormsApplication1
{
    partial class GAForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NumChromosomes = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.InitializationMethods = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumSubChromes = new System.Windows.Forms.TextBox();
            this.FitnessFunctions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CrossoverProbability = new System.Windows.Forms.TextBox();
            this.MutationProbability = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumGenerations = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SubChromeLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of chromosomes";
            // 
            // NumChromosomes
            // 
            this.NumChromosomes.Location = new System.Drawing.Point(160, 6);
            this.NumChromosomes.Name = "NumChromosomes";
            this.NumChromosomes.Size = new System.Drawing.Size(100, 20);
            this.NumChromosomes.TabIndex = 1;
            this.NumChromosomes.Text = "20";
            this.NumChromosomes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowIntegers);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(197, 256);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // InitializationMethods
            // 
            this.InitializationMethods.FormattingEnabled = true;
            this.InitializationMethods.Items.AddRange(new object[] {
            "Random Generation",
            "Manual Generation"});
            this.InitializationMethods.Location = new System.Drawing.Point(160, 137);
            this.InitializationMethods.Name = "InitializationMethods";
            this.InitializationMethods.Size = new System.Drawing.Size(100, 21);
            this.InitializationMethods.TabIndex = 7;
            this.InitializationMethods.Text = "(select from list)";
            this.InitializationMethods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DontAllow);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of sub-chromosomes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Which fitness function?";
            // 
            // NumSubChromes
            // 
            this.NumSubChromes.Location = new System.Drawing.Point(160, 32);
            this.NumSubChromes.Name = "NumSubChromes";
            this.NumSubChromes.Size = new System.Drawing.Size(100, 20);
            this.NumSubChromes.TabIndex = 3;
            this.NumSubChromes.Text = "2";
            this.NumSubChromes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowIntegers);
            // 
            // FitnessFunctions
            // 
            this.FitnessFunctions.FormattingEnabled = true;
            this.FitnessFunctions.Items.AddRange(new object[] {
            "Ackley\'s Function",
            "Booth\'s Function",
            "The Bulkin Function",
            "Time Slot Allocation Problem"});
            this.FitnessFunctions.Location = new System.Drawing.Point(160, 110);
            this.FitnessFunctions.Name = "FitnessFunctions";
            this.FitnessFunctions.Size = new System.Drawing.Size(100, 21);
            this.FitnessFunctions.TabIndex = 6;
            this.FitnessFunctions.Text = "(select from list)";
            this.FitnessFunctions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DontAllow);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "How will it be initialized?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crossover Probability";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mutation Probability";
            // 
            // CrossoverProbability
            // 
            this.CrossoverProbability.Location = new System.Drawing.Point(160, 164);
            this.CrossoverProbability.Name = "CrossoverProbability";
            this.CrossoverProbability.Size = new System.Drawing.Size(100, 20);
            this.CrossoverProbability.TabIndex = 8;
            this.CrossoverProbability.Text = "60";
            this.CrossoverProbability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDoubles);
            // 
            // MutationProbability
            // 
            this.MutationProbability.Location = new System.Drawing.Point(160, 190);
            this.MutationProbability.Name = "MutationProbability";
            this.MutationProbability.Size = new System.Drawing.Size(100, 20);
            this.MutationProbability.TabIndex = 9;
            this.MutationProbability.Text = "0.5";
            this.MutationProbability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDoubles);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Number of generations";
            // 
            // NumGenerations
            // 
            this.NumGenerations.Location = new System.Drawing.Point(160, 84);
            this.NumGenerations.Name = "NumGenerations";
            this.NumGenerations.Size = new System.Drawing.Size(100, 20);
            this.NumGenerations.TabIndex = 5;
            this.NumGenerations.Text = "50";
            this.NumGenerations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowIntegers);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Length of sub-chromosomes";
            // 
            // SubChromeLength
            // 
            this.SubChromeLength.Location = new System.Drawing.Point(160, 58);
            this.SubChromeLength.Name = "SubChromeLength";
            this.SubChromeLength.Size = new System.Drawing.Size(100, 20);
            this.SubChromeLength.TabIndex = 4;
            this.SubChromeLength.Text = "5";
            this.SubChromeLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowIntegers);
            // 
            // GAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.SubChromeLength);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumGenerations);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MutationProbability);
            this.Controls.Add(this.CrossoverProbability);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FitnessFunctions);
            this.Controls.Add(this.NumSubChromes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InitializationMethods);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.NumChromosomes);
            this.Controls.Add(this.label1);
            this.Name = "GAForm";
            this.Text = "GA Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumChromosomes;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox InitializationMethods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumSubChromes;
        private System.Windows.Forms.ComboBox FitnessFunctions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CrossoverProbability;
        private System.Windows.Forms.TextBox MutationProbability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NumGenerations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SubChromeLength;
    }
}

