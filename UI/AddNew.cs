using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace HHCalculator
{
    public partial class AddNew : Form
    {
        int EnterStrings = 0;
        int OutStrings = 0;
        public AddNew()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormAddNew_Shown(object sender, EventArgs e)
        {
            this.Text = ClassData.lang_current["FormAddNew"] + "...";
            LabelName.Text = ClassData.lang_current["Name"];
            LabelCount1.Text = ClassData.lang_current["InCount"];
            LabelCount2.Text = ClassData.lang_current["OutCount"];
            ButtonNext.Text = ClassData.lang_current["BtnContinue"];
            ButtonNext.Location = new Point(this.ClientSize.Width / 2 - ButtonNext.Width / 2, ButtonNext.Location.Y);
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text != String.Empty && Int32.TryParse(TextBoxCount1.Text, out EnterStrings) && Int32.TryParse(TextBoxCount2.Text, out OutStrings) && EnterStrings > 0 && OutStrings > 0)
            {
                this.Text = ClassData.lang_current["FormAddNew"] + " \"" + TextBoxName.Text + "\"";
                LabelName.Hide();
                LabelCount1.Hide();
                LabelCount2.Hide();
                TextBoxName.Hide();
                TextBoxCount1.Hide();
                TextBoxCount2.Hide();
                ButtonNext.Hide();
                for (int i = 0; i < EnterStrings; i++)
                {
                    if (i == 0)
                    {
                        Label LabelName = new Label
                        {
                            AutoSize = true,
                            Location = new Point(8, 8),
                            Name = "InNames",
                            Text = ClassData.lang_current["InNames"]
                        };
                        this.Controls.Add(LabelName);
                    }
                    Label Label = new Label
                    {
                        AutoSize = true,
                        Location = new Point(8, 8 + 26 * (i + 1)),
                        Name = "InLabel" + i.ToString(),
                        Text = "v" + (i + 1).ToString()
                    };
                    this.Controls.Add(Label);
                    TextBox TextBox = new TextBox
                    {
                        Size = new Size(100, 20),
                        Location = new Point(49, 5 + 26 * (i + 1)),
                        Name = "InTextBox" + i.ToString(),
                        Text = ""
                    };
                    this.Controls.Add(TextBox);
                }
                for (int i = 0; i < OutStrings; i++)
                {
                    if (i == 0)
                    {
                        Label LabelName = new Label
                        {
                            AutoSize = true,
                            Location = new Point(200, 8),
                            Name = "OutNames",
                            Text = ClassData.lang_current["OutNames"]
                        };
                        this.Controls.Add(LabelName);
                    }
                    TextBox TextBoxName = new TextBox
                    {
                        Size = new Size(100, 20),
                        Location = new Point(200, 5 + 26 * (i + 1)),
                        Name = "OutTextBoxName" + i.ToString()
                    };
                    this.Controls.Add(TextBoxName);
                    TextBox TextBox = new TextBox
                    {
                        Size = new Size(100, 20),
                        Location = new Point(320, 5 + 26 * (i + 1)),
                        Name = "OutTextBox" + i.ToString()
                    };
                    this.Controls.Add(TextBox);
                }
                Button ButtonFinish = new Button
                {
                    AutoSize = true,
                    Name = "ButtonFinish",
                    Text = ClassData.lang_current["FinishBtn"]
                };
                if (EnterStrings > OutStrings) ButtonFinish.Location = new Point(8, 16 + 26 + 26 * EnterStrings); else ButtonFinish.Location = new Point(8, 16 + 26 + 26 * OutStrings);
                this.Controls.Add(ButtonFinish);
                if (this.Controls["OutNames"].Location.X + this.Controls["OutNames"].Width > this.Controls["OutTextBox0"].Location.X + this.Controls["OutTextBox0"].Width)
                {
                    this.Size = new Size(this.Controls["OutNames"].Location.X + this.Controls["OutNames"].Width + 48, this.Height);
                }
                else
                {
                    this.Size = new Size(this.Controls["OutTextBox0"].Location.X + this.Controls["OutTextBox0"].Width + 48, this.Height);
                }
                if (this.Controls["ButtonFinish"].Location.Y > this.Size.Height * 0.9)
                {
                    this.Size = new Size(this.Size.Width, this.Controls["ButtonFinish"].Location.Y + this.Controls["ButtonFinish"].Size.Height + 48);
                }
                if (this.Controls["ButtonFinish"].Location.Y > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height - System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height / 8)
                {
                    this.AutoScroll = true;
                    this.VScroll = false;
                    this.Size = new Size(this.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height - System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height / 8);
                }
                this.Controls["ButtonFinish"].Location = new Point(this.Width / 2 - this.Controls["ButtonFinish"].Width / 2, this.Controls["ButtonFinish"].Location.Y);
                this.Controls["ButtonFinish"].Click += new System.EventHandler(this.ButtonFinish_Click);
            }
            
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            bool ParseSuccess = true;
            for (int i = 0; i < EnterStrings; i++)
            {
                if (ParseSuccess && string.IsNullOrWhiteSpace(this.Controls["InTextBox" + i.ToString()].Text))
                {
                    ParseSuccess = false;
                    MessageBox.Show("Введите название входной переменной v" + (i + 1).ToString(), "Ошибка");
                }
            }
            if (ParseSuccess && OutStrings > 1) {
                for (int i = 0; i < OutStrings; i++)
                {
                    if (ParseSuccess && string.IsNullOrWhiteSpace(this.Controls["OutTextBoxName" + i.ToString()].Text))
                    {
                        ParseSuccess = false;
                        MessageBox.Show("Введите название выходной переменной №" + (i + 1).ToString(), "Ошибка");
                    }
                }
            }
            if (ParseSuccess)
            {
                for (int i = 0; i < OutStrings; i++)
                {
                    if (ParseSuccess)
                    {
                        string entry = this.Controls["OutTextBox" + i.ToString()].Text;
                        if (ClassFunctions.FormulaCheck(entry, i + 1))
                        {
                            string formula = String.Empty;
                            for (int j = 0; j < entry.Length; j++)
                            {
                                if (entry[j] == 'v')
                                {
                                    if (entry.Length > j + 1 && "0123456789".Contains(entry[j + 1]))
                                    {
                                        string num = "";
                                        while (entry.Length > j + 1 && "0123456789".Contains(entry[j + 1]))
                                        {
                                            num += entry[j + 1];
                                            j++;
                                        }
                                        if (Int32.TryParse(num, out int number) && number <= EnterStrings && number > 0)
                                        {
                                            formula = formula + "$value=" + number.ToString() + "$";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error_4", "Warning");
                                        }
                                    }
                                }
                                else if (")".Contains(entry[j])) formula = formula + (entry[j]);
                                else if ("+-*/".Contains(entry[j]))
                                {
                                    formula = formula + (entry[j]);
                                    if (entry.Length > j + 1 && !"v".Contains(entry[j + 1]))
                                    {
                                        if (entry.Length > j + 1 && "(0123456789".Contains(entry[j + 1]))
                                        {
                                            string num = "";
                                            while (entry.Length > j + 1 && "(0123456789".Contains(entry[j + 1]))
                                            {
                                                num += entry[j + 1];
                                                j++;
                                            }
                                            formula = formula + num;
                                        }
                                    }
                                }
                                else if ("(123456789".Contains(entry[j]))
                                {
                                    string num = entry[j].ToString();
                                    if (entry.Length > j + 1 && "0123456789)".Contains(entry[j + 1]))
                                    {
                                        while (entry.Length > j + 1 && "0123456789)".Contains(entry[j + 1]))
                                        {
                                            num += entry[j + 1];
                                            j++;
                                        }
                                    }
                                    formula = formula + num;
                                }
                            }
                        }
                        else ParseSuccess = false;
                    }
                }
            }
            if (ParseSuccess)
            {
                string XmlString =
                    @"<?xml version=""1.0"" encoding=""utf-8""?>
<Root>";
                XmlString += String.Format("\n  <Name>{0}</Name>", TextBoxName.Text);
                XmlString += "\n  <Input>";
                for (int i = 0; i < EnterStrings; i++)
                {
                    XmlString += string.Format("\n    <Var{0}>{1}</Var{0}>", i + 1, this.Controls["InTextBox" + i.ToString()].Text);
                }
                XmlString += @"
  </Input>
  <Output>";
                for (int i = 0; i < OutStrings; i++)
                {
                    XmlString += string.Format("\n    <{0} name=\"{2}\">{1}</{0}>", "Out" + i.ToString(), this.Controls["OutTextBox" + i.ToString()].Text, this.Controls["OutTextBoxName" + i.ToString()].Text);
            }
                XmlString += @"
  </Output>
</Root>";
                XDocument doc = XDocument.Parse(XmlString);
                if (!Directory.Exists(ClassData.UserFormsPath)) Directory.CreateDirectory(ClassData.UserFormsPath);
                string[] ExternalNames = Directory.GetFiles(ClassData.UserFormsPath, "*.xml");
                int Number = -1;
                foreach (string ExternalName in ExternalNames)
                {
                    string[] SplitName = ExternalName.Split('_');
                    if (Int32.TryParse(SplitName[SplitName.Length - 1].Split('.')[0], out int Num) && Num > Number) Number = Num;
                }
                Number++;
                doc.Save(ClassData.UserFormsPath + "\\userform_" + Number.ToString() + ".xml");
                //ClassFunctions.FillMainForm();
                this.Hide();
                ClassData.AddNew = new AddNew();
            }
        }

        private void FormAddNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
