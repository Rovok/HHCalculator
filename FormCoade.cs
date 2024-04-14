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
    public partial class FormCoade : Form
    {
        public FormCoade()
        {
            InitializeComponent();
            buttonCalc.Location = new Point(this.ClientSize.Width / 2 - buttonCalc.Width / 2, 355);
            this.Text = "Coade clay";
        }

        private void UpdateCheckboxes()
        {
            if (checkBoxBranch.Checked)
            {
                textBoxBranch.Enabled = true;
                this.labelBlock.Font = ClassData.FontStrikeout;
                this.labelAxe.Font = ClassData.FontStrikeout;
            }
            else
            {
                textBoxBranch.Enabled = false;
                this.labelBlock.Font = ClassData.FontRegular;
                this.labelAxe.Font = ClassData.FontRegular;
            }
            if (checkBoxAsh.Checked)
            {
                textBoxAsh.Enabled = true;
            }
            else
            {
                textBoxAsh.Enabled = false;
            }
            if (checkBoxLye.Checked)
            {
                textBoxLye.Enabled = true;
            }
            else
            {
                textBoxLye.Enabled = false;
            }
            if (checkBoxBrick.Checked)
            {
                textBoxBrick.Enabled = true;
            }
            else
            {
                textBoxBrick.Enabled = false;
            }
        }

        private void FillForm()
        {
            if (ClassData.Qualities["log"] != 0) textBoxBlock.Text = ClassData.Qualities["log"].ToString();
            if (ClassData.Qualities["stone_axe"] != 0) textBoxAxe.Text = ClassData.Qualities["stone_axe"].ToString();
            if (ClassData.Qualities["cauldron"] != 0) textBoxCauldron.Text = ClassData.Qualities["cauldron"].ToString();
            if (ClassData.Qualities["ball_clay"] != 0) textBoxClay.Text = ClassData.Qualities["ball_clay"].ToString();
            if (ClassData.Qualities["sand"] != 0) textBoxSand.Text = ClassData.Qualities["sand"].ToString();
            if (ClassData.Qualities["quartz"] != 0) textBoxQuartz.Text = ClassData.Qualities["quartz"].ToString();
            if (ClassData.Qualities["flint"] != 0) textBoxFlint.Text = ClassData.Qualities["flint"].ToString();
            if (ClassData.Qualities["kiln"] != 0) textBoxKiln.Text = ClassData.Qualities["kiln"].ToString();
            textBoxBranch.Text = string.Empty;
            textBoxAsh.Text = string.Empty;
            textBoxLye.Text = string.Empty;
            textBoxBrick.Text = string.Empty;
            checkBoxBranch.Checked = false;
            checkBoxAsh.Checked = false;
            checkBoxLye.Checked = false;
            checkBoxBrick.Checked = false;
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            FillForm();
        }

        private void checkBoxBranch_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckboxes();
        }

        private void checkBoxAsh_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckboxes();
        }

        private void checkBoxLye_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckboxes();
        }

        private void checkBoxBrick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckboxes();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            bool ShowError = false;
            double Qbranch = 0;
            double Qash = 0;
            double Qlye = 0;
            double Qbrick = 0;
            if (!double.TryParse(textBoxBlock.Text, out double Qblock)) ShowError = true;
            if (!double.TryParse(textBoxAxe.Text, out double Qaxe)) ShowError = true;
            if (!double.TryParse(textBoxCauldron.Text, out double Qcauldron)) ShowError = true;
            if (!double.TryParse(textBoxClay.Text, out double Qclay)) ShowError = true;
            if (!double.TryParse(textBoxSand.Text, out double Qsand)) ShowError = true;
            if (!double.TryParse(textBoxQuartz.Text, out double Qquartz)) ShowError = true;
            if (!double.TryParse(textBoxFlint.Text, out double Qflint)) ShowError = true;
            if (!double.TryParse(textBoxKiln.Text, out double Qkiln)) ShowError = true;
            if (!checkBoxBranch.Checked) Qbranch = Math.Sqrt(Qblock * Qaxe);
            else if (!double.TryParse(textBoxBranch.Text, out Qbranch)) ShowError = true;
            if (!checkBoxAsh.Checked) Qash = Qbranch;
            else if (!double.TryParse(textBoxAsh.Text, out Qash)) ShowError = true;
            if (!checkBoxLye.Checked) Qlye = (Qash + Qcauldron) / 2;
            else if (!double.TryParse(textBoxLye.Text, out Qlye)) ShowError = true;
            if (!checkBoxBrick.Checked) Qbrick = (Qclay * 2 + Qbranch + Qkiln) / 4;
            else if (!double.TryParse(textBoxBrick.Text, out Qbrick)) ShowError = true;
            if (ShowError)
            {
                MessageBox.Show("Введены неверные данные", "Ошибка");
            }
            else
            {
                double result = Math.Round(((Qsand + Qlye) / 2 + Qclay + Qbrick + Qquartz + Qflint) / 5, 2);
                labelResult.Text = "Результат: " + result.ToString();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            FillForm();
            this.Hide();
        }
    }
}
