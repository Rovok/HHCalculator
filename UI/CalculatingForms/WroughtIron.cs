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
    public partial class WroughtIron : Form
    {
        private double[] smithVars = new double[3];
        public WroughtIron()
        {
            InitializeComponent();
        }

        private void FormWroughtIron_Shown(object sender, EventArgs e)
        {
            if (ClassData.Qualities["anvil"] != 0) textBoxAnvil.Text = ClassData.Qualities["anvil"].ToString();
            if (ClassData.Qualities["hammer"] != 0) textBoxHammer.Text = ClassData.Qualities["hammer"].ToString();
            labelAnvil.Text = "Наковальня";
            labelHammer.Text = "Молот";
            labelBloom.Text = "Bloom";
            labelOption1.Text = "Шанс 10%:";
            labelOption2.Text = "Шанс 45%:";
            labelOption3.Text = "Шанс 45%:";
            labelVar1.Text = "";
            labelVar2.Text = "";
            labelVar3.Text = "";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBoxAnvil.Text, out double anvil) && Double.TryParse(textBoxHammer.Text, out double hammer) && Double.TryParse(textBoxBloom.Text, out double bloom)) {
                smithVars = ClassFormulas.WroughtIronSmith(anvil, hammer, bloom);
                labelVar1.Text = smithVars[0].ToString();
                labelVar2.Text = smithVars[1].ToString();
                labelVar3.Text = smithVars[2].ToString();
            }
        }

        private void FormWroughtIron_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            FormWroughtIron_Shown(sender, e);
        }
    }
}
