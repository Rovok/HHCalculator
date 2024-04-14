namespace HHCalculator
{
    partial class FormBoardAndBranch
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
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxTool = new System.Windows.Forms.TextBox();
            this.textBoxWood = new System.Windows.Forms.TextBox();
            this.labelTool = new System.Windows.Forms.Label();
            this.labelWood = new System.Windows.Forms.Label();
            this.labelResultName = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(322, 337);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "button1";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxTool
            // 
            this.textBoxTool.Location = new System.Drawing.Point(179, 42);
            this.textBoxTool.Name = "textBoxTool";
            this.textBoxTool.Size = new System.Drawing.Size(100, 20);
            this.textBoxTool.TabIndex = 1;
            // 
            // textBoxWood
            // 
            this.textBoxWood.Location = new System.Drawing.Point(186, 85);
            this.textBoxWood.Name = "textBoxWood";
            this.textBoxWood.Size = new System.Drawing.Size(100, 20);
            this.textBoxWood.TabIndex = 2;
            // 
            // labelTool
            // 
            this.labelTool.AutoSize = true;
            this.labelTool.Location = new System.Drawing.Point(53, 37);
            this.labelTool.Name = "labelTool";
            this.labelTool.Size = new System.Drawing.Size(75, 13);
            this.labelTool.TabIndex = 3;
            this.labelTool.Text = "Пила / Топор";
            // 
            // labelWood
            // 
            this.labelWood.AutoSize = true;
            this.labelWood.Location = new System.Drawing.Point(56, 87);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(64, 13);
            this.labelWood.TabIndex = 4;
            this.labelWood.Text = "Древесина";
            // 
            // labelResultName
            // 
            this.labelResultName.AutoSize = true;
            this.labelResultName.Location = new System.Drawing.Point(380, 64);
            this.labelResultName.Name = "labelResultName";
            this.labelResultName.Size = new System.Drawing.Size(59, 13);
            this.labelResultName.TabIndex = 5;
            this.labelResultName.Text = "Результат";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(485, 64);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(29, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "label";
            // 
            // FormBoardAndBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelResultName);
            this.Controls.Add(this.labelWood);
            this.Controls.Add(this.labelTool);
            this.Controls.Add(this.textBoxWood);
            this.Controls.Add(this.textBoxTool);
            this.Controls.Add(this.buttonCalc);
            this.Name = "FormBoardAndBranch";
            this.Text = "FormBoardAndBranch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBoardAndBranch_FormClosing);
            this.Shown += new System.EventHandler(this.FormBoardAndBranch_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxTool;
        private System.Windows.Forms.TextBox textBoxWood;
        private System.Windows.Forms.Label labelTool;
        private System.Windows.Forms.Label labelWood;
        private System.Windows.Forms.Label labelResultName;
        private System.Windows.Forms.Label labelResult;
    }
}