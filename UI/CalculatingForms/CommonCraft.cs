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
    public partial class CommonCraft : Form
    {
        private static Control[] Entries = new Control[10];
        public CommonCraft()
        {
            InitializeComponent();
            this.Text = "Крафт / Строительство";
        }

        private void FormCommonCraft_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < Entries.Length; i++)
            {
                Entries[i] = this.Controls["textBox" + (i + 1).ToString()];
            }
            for (int i = 2; i < Entries.Length; i++) Entries[i].Enabled = false;
            buttonMinus.Enabled = false;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < Int32.Parse(labelCount.Text); i++)
            {
                if (Double.TryParse(Entries[i].Text, out double result))
                {
                    count++;
                    sum += result;
                }
                else
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка");
                    return;
                }
            }
            labelResult.Text = (sum / count).ToString();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            for (int i = 2; i < Entries.Length; i++) Entries[i].Enabled = false;
            foreach (Control c in Entries) c.Text = String.Empty;
            labelResult.Text = String.Empty;
            labelCount.Text = "2";
            FormUpdate();
        }

        private void FormUpdate()
        {
            if (Int32.Parse(labelCount.Text) <= 2) buttonMinus.Enabled = false; else buttonMinus.Enabled = true;
            if (Int32.Parse(labelCount.Text) >= 10) buttonPlus.Enabled = false; else buttonPlus.Enabled = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelCount.Text = (Int32.Parse(labelCount.Text) + 1).ToString();
            this.Controls["textBox" + Int32.Parse(labelCount.Text).ToString()].Enabled = true;
            FormUpdate();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.Controls["textBox" + Int32.Parse(labelCount.Text).ToString()].Enabled = false;
            labelCount.Text = (Int32.Parse(labelCount.Text) - 1).ToString();
            FormUpdate();
        }
    }
}
