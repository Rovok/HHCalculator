using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HHCalculator
{
    public partial class FormSettings : Form
    {
        private bool edited = false;
        public FormSettings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormSettings_Shown(object sender, EventArgs e)
        {
            btnSave.Location = new Point(this.ClientSize.Width / 2 - btnSave.Width / 2, 254);
            textBox1.KeyPress += new KeyPressEventHandler(keypressed);
            this.Text = "Настройки";
            label1.Text = "version: " + ClassData.Version;
            ClassFunctions.FillList(listBox1);
        }

        private void keypressed(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                btnEdit_Click(o, e);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            if (edited)
            {
                Form errForm = new Form();
                errForm.ClientSize = new System.Drawing.Size(200, 50);
                Button button1 = new Button();
                Label label = new Label();
                label.Name = "label";
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(5, 5);
                label.TabIndex = 0;
                label.Text = "Изменённые данные не сохранены";
                button1.Text = "OK";
                button1.Location = new Point(errForm.ClientSize.Width / 2 - button1.Width / 2, 20);
                errForm.Text = "Внимание";
                errForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                errForm.MaximizeBox = false;
                errForm.MinimizeBox = false;
                errForm.CancelButton = button1;
                errForm.StartPosition = FormStartPosition.CenterScreen;
                errForm.Controls.Add(button1);
                errForm.Controls.Add(label);
                errForm.ShowDialog();
            }
            this.Hide();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            File.Delete(ClassData.FilePath);
            ClassFunctions.RewriteFile(ClassData.FilePath);
            edited = false;
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            int index = Convert.ToInt32(listBox1.SelectedIndex);
            if (index != -1)
            {
                btnEdit.Enabled = true;
                if (Int32.TryParse(textBox1.Text, out int value) | textBox1.Text == "")
                {
                    string[] temp = listBox1.SelectedItem.ToString().Split('=');
                    temp[0] = temp[0].Remove(temp[0].Length - 1);
                    ClassFunctions.Edit(temp[0], value);
                    ClassFunctions.FillList(listBox1);
                    btnEdit.Enabled = false;
                    edited = true;
                }
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(listBox1.SelectedIndex);
            if (index == -1)
                btnEdit.Enabled = false;
            else
                btnEdit.Enabled = true;
            if (listBox1.SelectedItem != null)
            {
                string[] name = listBox1.SelectedItem.ToString().Split('=');
                if (name[1] != null & (Int32.TryParse(name[1], out int numValue)))
                    textBox1.Text = numValue.ToString();
                else
                    textBox1.Text = "";
                textBox1.Select();
            }
        }
    }
}
