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
    public partial class FormBoardAndBranch : Form
    {
        public FormBoardAndBranch()
        {
            InitializeComponent();
        }

        private void FormBoardAndBranch_Shown(object sender, EventArgs e)
        {

        }

        private void FormBoardAndBranch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBoxTool.Text, out double tool) && Double.TryParse(textBoxWood.Text, out double wood))
            {
                labelResult.Text = Math.Round(ClassFormulas.BoardAndBranch(tool, wood), 2).ToString();
            }
        }
    }
}
