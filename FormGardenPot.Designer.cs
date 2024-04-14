namespace HHCalculator
{
    partial class FormGardenPot
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
            this.labelSoil = new System.Windows.Forms.Label();
            this.labelWater = new System.Windows.Forms.Label();
            this.labelPot = new System.Windows.Forms.Label();
            this.labelSeed = new System.Windows.Forms.Label();
            this.textBoxSoil = new System.Windows.Forms.TextBox();
            this.textBoxWater = new System.Windows.Forms.TextBox();
            this.textBoxPot = new System.Windows.Forms.TextBox();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPlanted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSoil
            // 
            this.labelSoil.AutoSize = true;
            this.labelSoil.Location = new System.Drawing.Point(10, 10);
            this.labelSoil.Name = "labelSoil";
            this.labelSoil.Size = new System.Drawing.Size(40, 13);
            this.labelSoil.TabIndex = 0;
            this.labelSoil.Text = "Земля";
            // 
            // labelWater
            // 
            this.labelWater.AutoSize = true;
            this.labelWater.Location = new System.Drawing.Point(10, 35);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(32, 13);
            this.labelWater.TabIndex = 1;
            this.labelWater.Text = "Вода";
            // 
            // labelPot
            // 
            this.labelPot.AutoSize = true;
            this.labelPot.Location = new System.Drawing.Point(10, 60);
            this.labelPot.Name = "labelPot";
            this.labelPot.Size = new System.Drawing.Size(45, 13);
            this.labelPot.TabIndex = 2;
            this.labelPot.Text = "Горшок";
            // 
            // labelSeed
            // 
            this.labelSeed.AutoSize = true;
            this.labelSeed.Location = new System.Drawing.Point(10, 85);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(46, 13);
            this.labelSeed.TabIndex = 4;
            this.labelSeed.Text = "Семена";
            // 
            // textBoxSoil
            // 
            this.textBoxSoil.Location = new System.Drawing.Point(65, 7);
            this.textBoxSoil.Name = "textBoxSoil";
            this.textBoxSoil.Size = new System.Drawing.Size(80, 20);
            this.textBoxSoil.TabIndex = 5;
            // 
            // textBoxWater
            // 
            this.textBoxWater.Location = new System.Drawing.Point(65, 30);
            this.textBoxWater.Name = "textBoxWater";
            this.textBoxWater.Size = new System.Drawing.Size(80, 20);
            this.textBoxWater.TabIndex = 6;
            // 
            // textBoxPot
            // 
            this.textBoxPot.Location = new System.Drawing.Point(65, 55);
            this.textBoxPot.Name = "textBoxPot";
            this.textBoxPot.Size = new System.Drawing.Size(80, 20);
            this.textBoxPot.TabIndex = 7;
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(65, 80);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(80, 20);
            this.textBoxSeed.TabIndex = 9;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(41, 161);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 10;
            this.buttonCalc.Text = "Вычислить";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(15, 115);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(67, 13);
            this.labelMax.TabIndex = 11;
            this.labelMax.Text = "Максимум: ";
            // 
            // labelPlanted
            // 
            this.labelPlanted.AutoSize = true;
            this.labelPlanted.Location = new System.Drawing.Point(15, 135);
            this.labelPlanted.Name = "labelPlanted";
            this.labelPlanted.Size = new System.Drawing.Size(78, 13);
            this.labelPlanted.TabIndex = 12;
            this.labelPlanted.Text = "Высаженное: ";
            // 
            // FormGardenPot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 196);
            this.Controls.Add(this.labelPlanted);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.textBoxPot);
            this.Controls.Add(this.textBoxWater);
            this.Controls.Add(this.textBoxSoil);
            this.Controls.Add(this.labelSeed);
            this.Controls.Add(this.labelPot);
            this.Controls.Add(this.labelWater);
            this.Controls.Add(this.labelSoil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGardenPot";
            this.Text = "Садовый горшок";
            this.Shown += new System.EventHandler(this.FormGardenPot_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoil;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.Label labelPot;
        private System.Windows.Forms.Label labelSeed;
        private System.Windows.Forms.TextBox textBoxSoil;
        private System.Windows.Forms.TextBox textBoxWater;
        private System.Windows.Forms.TextBox textBoxPot;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelPlanted;
    }
}