namespace HHCalculator
{
    partial class FormAddNew
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
            this.LabelCount1 = new System.Windows.Forms.Label();
            this.LabelCount2 = new System.Windows.Forms.Label();
            this.TextBoxCount1 = new System.Windows.Forms.TextBox();
            this.TextBoxCount2 = new System.Windows.Forms.TextBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelCount1
            // 
            this.LabelCount1.AutoSize = true;
            this.LabelCount1.Location = new System.Drawing.Point(8, 58);
            this.LabelCount1.Name = "LabelCount1";
            this.LabelCount1.Size = new System.Drawing.Size(30, 13);
            this.LabelCount1.TabIndex = 6;
            this.LabelCount1.Text = "entry";
            // 
            // LabelCount2
            // 
            this.LabelCount2.AutoSize = true;
            this.LabelCount2.Location = new System.Drawing.Point(8, 108);
            this.LabelCount2.Name = "LabelCount2";
            this.LabelCount2.Size = new System.Drawing.Size(22, 13);
            this.LabelCount2.TabIndex = 2;
            this.LabelCount2.Text = "out";
            // 
            // TextBoxCount1
            // 
            this.TextBoxCount1.Location = new System.Drawing.Point(12, 80);
            this.TextBoxCount1.Name = "TextBoxCount1";
            this.TextBoxCount1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCount1.TabIndex = 1;
            // 
            // TextBoxCount2
            // 
            this.TextBoxCount2.Location = new System.Drawing.Point(12, 130);
            this.TextBoxCount2.Name = "TextBoxCount2";
            this.TextBoxCount2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCount2.TabIndex = 2;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(128, 170);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(100, 23);
            this.ButtonNext.TabIndex = 4;
            this.ButtonNext.Text = "button1";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(8, 8);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(33, 13);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "name";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(12, 30);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 0;
            // 
            // FormAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 208);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.TextBoxCount2);
            this.Controls.Add(this.TextBoxCount1);
            this.Controls.Add(this.LabelCount2);
            this.Controls.Add(this.LabelCount1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddNew";
            this.Text = "FormAddNew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddNew_FormClosing);
            this.Shown += new System.EventHandler(this.FormAddNew_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCount1;
        private System.Windows.Forms.Label LabelCount2;
        private System.Windows.Forms.TextBox TextBoxCount1;
        private System.Windows.Forms.TextBox TextBoxCount2;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
    }
}