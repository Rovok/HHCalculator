namespace HHCalculator
{
    partial class FormHHP
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelConst = new System.Windows.Forms.Label();
            this.labelHHP = new System.Windows.Forms.Label();
            this.textBoxHHP = new System.Windows.Forms.TextBox();
            this.textBoxConst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HHP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Constitution";
            // 
            // labelConst
            // 
            this.labelConst.AutoSize = true;
            this.labelConst.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConst.Location = new System.Drawing.Point(170, 12);
            this.labelConst.Name = "labelConst";
            this.labelConst.Size = new System.Drawing.Size(22, 15);
            this.labelConst.TabIndex = 2;
            this.labelConst.Text = "=> ";
            // 
            // labelHHP
            // 
            this.labelHHP.AutoSize = true;
            this.labelHHP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelHHP.Location = new System.Drawing.Point(170, 42);
            this.labelHHP.Name = "labelHHP";
            this.labelHHP.Size = new System.Drawing.Size(22, 15);
            this.labelHHP.TabIndex = 3;
            this.labelHHP.Text = "=> ";
            // 
            // textBoxHHP
            // 
            this.textBoxHHP.Location = new System.Drawing.Point(100, 9);
            this.textBoxHHP.Name = "textBoxHHP";
            this.textBoxHHP.Size = new System.Drawing.Size(70, 20);
            this.textBoxHHP.TabIndex = 4;
            this.textBoxHHP.TextChanged += new System.EventHandler(this.textBoxHHP_TextChanged);
            // 
            // textBoxConst
            // 
            this.textBoxConst.Location = new System.Drawing.Point(100, 39);
            this.textBoxConst.Name = "textBoxConst";
            this.textBoxConst.Size = new System.Drawing.Size(70, 20);
            this.textBoxConst.TabIndex = 5;
            this.textBoxConst.TextChanged += new System.EventHandler(this.textBoxConst_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "(Constitution)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "(HHP)";
            // 
            // FormHHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 72);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConst);
            this.Controls.Add(this.textBoxHHP);
            this.Controls.Add(this.labelHHP);
            this.Controls.Add(this.labelConst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHHP";
            this.Text = "FormHHP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHHP_FormClosing);
            this.Shown += new System.EventHandler(this.FormHHP_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConst;
        private System.Windows.Forms.Label labelHHP;
        private System.Windows.Forms.TextBox textBoxHHP;
        private System.Windows.Forms.TextBox textBoxConst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}