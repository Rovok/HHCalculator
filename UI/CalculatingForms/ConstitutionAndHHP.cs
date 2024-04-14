using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHCalculator
{
    public partial class ConstitutionAndHHP : Form
    {
        public ConstitutionAndHHP()
        {
            InitializeComponent();
        }

        private void FormHHP_Shown(object sender, EventArgs e)
        {
            this.Text = "HHP <=> Телосложение";
            this.AutoSize = true;
            label5.Location = new Point(labelConst.Right, label5.Location.Y);
            label6.Location = new Point(labelHHP.Right, label6.Location.Y);
            label1.Text = "HHP";
            label2.Text = "Телосложение";
            label5.Text = "(Телосложение)";
            label6.Text = "(HHP)";
        }

        private void textBoxHHP_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxHHP.Text)) labelConst.Text = "=> ";
            if (Double.TryParse(textBoxHHP.Text, out double hp))
            {
                labelConst.Text = "=> " + Math.Round(Math.Pow(hp / 100, 2) * 10, 0).ToString();
            }
            label5.Location = new Point(labelConst.Right, label5.Location.Y);
        }

        private void textBoxConst_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxConst.Text)) labelHHP.Text = "=> ";
            if (Double.TryParse(textBoxConst.Text, out double cnst))
            {
                labelHHP.Text = "=> " + Math.Round(Math.Sqrt(cnst / 10) * 100, 0).ToString();
            }
            label6.Location = new Point(labelHHP.Right, label6.Location.Y);
        }

        private void FormHHP_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            textBoxHHP.Text = String.Empty;
            textBoxConst.Text = String.Empty;
        }
    }
}
