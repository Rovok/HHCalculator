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
    public partial class FormSmith : Form
    {
        private static Control[] Entries = new Control[5];
        public FormSmith()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            buttonCalc.Location = new Point(this.ClientSize.Width / 2 - buttonCalc.Width / 2, buttonCalc.Location.Y);
            this.Text = "Ковка";
        }

        private void FormSmith_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < Entries.Length; i++)
            {
                Entries[i] = this.Controls["textBoxMat" + i.ToString()];
            }
            for (int i = 1; i < Entries.Length; i++) Entries[i].Enabled = false;
            buttonMinus.Enabled = false;
            if (ClassData.Qualities["anvil"] != 0) textBoxAnvil.Text = ClassData.Qualities["anvil"].ToString();
            if (ClassData.Qualities["hammer"] != 0) textBoxHammer.Text = ClassData.Qualities["hammer"].ToString();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            for (int i = 1; i < Entries.Length; i++) Entries[i].Enabled = false;
            foreach (Control c in Entries) c.Text = String.Empty;
            labelResult.Text = String.Empty;
            labelCount.Text = "1";
            FormUpdate();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBoxAnvil.Text, out double anvil) && Double.TryParse(textBoxHammer.Text, out double hammer))
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
                labelResult.Text = Math.Round(ClassFormulas.CraftSmith(anvil, hammer, sum / count), 2).ToString();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка");
            }
        }

        private void FormUpdate()
        {
            if (Int32.Parse(labelCount.Text) <= 1) buttonMinus.Enabled = false; else buttonMinus.Enabled = true;
            if (Int32.Parse(labelCount.Text) >= 5) buttonPlus.Enabled = false; else buttonPlus.Enabled = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.Controls["textBoxMat" + Int32.Parse(labelCount.Text).ToString()].Enabled = true;
            labelCount.Text = (Int32.Parse(labelCount.Text) + 1).ToString();
            FormUpdate();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.Controls["textBoxMat" + (Int32.Parse(labelCount.Text) - 1).ToString()].Enabled = false;
            labelCount.Text = (Int32.Parse(labelCount.Text) - 1).ToString();
            FormUpdate();
        }
    }
}
