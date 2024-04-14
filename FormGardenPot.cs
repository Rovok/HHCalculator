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
    public partial class FormGardenPot : Form
    {
        public FormGardenPot()
        {
            InitializeComponent();
        }

        private void FillForm()
        {
            if (ClassData.Qualities["mulch"] != 0) textBoxSoil.Text = ClassData.Qualities["mulch"].ToString();
            if (ClassData.Qualities["common_water"] != 0) textBoxWater.Text = ClassData.Qualities["common_water"].ToString();
            if (ClassData.Qualities["treeplanters_pot"] != 0) textBoxPot.Text = ClassData.Qualities["treeplanters_pot"].ToString();
            textBoxSeed.Text = "";
            labelPlanted.Text = "Высаженное: ";
            labelMax.Text = "Максимум: ";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBoxSoil.Text, out double Soil) && Double.TryParse(textBoxWater.Text, out double Water) && Double.TryParse(textBoxPot.Text, out double Pot))
            {
                if (Double.TryParse(textBoxSeed.Text, out double Seed))
                {
                    double Planted = Math.Round((Soil + Water + Pot * 10 + Seed * 8) / 20, 2);
                    labelPlanted.Text = "Высаженное: " + Planted.ToString() + " ± 5";
                }
                double Max = Math.Round((Soil + Water + Pot * 10) / 12, 2);
                labelMax.Text = "Максимум: " + Max.ToString();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка");
            }
        }

        private void FormGardenPot_Shown(object sender, EventArgs e)
        {
            FillForm();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            FillForm();
            this.Hide();
        }
    }
}
