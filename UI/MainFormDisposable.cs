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
using System.Net;
using System.Diagnostics;
using System.Xml.Linq;

namespace HHCalculator
{
    public partial class MainFormDisposable : Form
    {
        public MainFormDisposable(string[] args)
        {
            Program.MainForm = this;
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = new Size(10, 10);
            //UpdateCheck();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            if (!Directory.Exists(ClassData.ApplicationFolder)) Directory.CreateDirectory(ClassData.ApplicationFolder);
            if (!File.Exists(ClassData.FilePath)) ClassFunctions.CreateNewFile(ClassData.FilePath);
            this.Text = "hh калькулятор";
            btnSelect.Enabled = false;
            ClassFunctions.UpdateQualitiesDict(ClassFunctions.ReadUserQualities(ClassData.FilePath));
            ClassFunctions.CreateConvertVariables();
            //ClassFunctions.FillMainForm();
            ClassData.UI.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //    if (listBox1.SelectedIndex == -1) return;
            //    string selectedItem = listBox1.SelectedItem.ToString();
            //    if (ClassData.InternalForms.ContainsKey(selectedItem))
            //    {
            //        Form c = ClassData.InternalForms[selectedItem];
            //        c.StartPosition = FormStartPosition.CenterScreen;
            //        if (c.Visible)
            //        {
            //            c.WindowState = FormWindowState.Normal;
            //            c.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width / 2 - c.ClientSize.Width / 2, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height / 2 - c.ClientSize.Height / 2);
            //            c.Activate();
            //        }
            //        if (!c.Visible & c != null)
            //        {
            //            c.Show();
            //        }
            //    }
            //    else if (ClassData.ExternalForms.ContainsKey(listBox1.SelectedIndex))
            //    {
            //        XDocument doc = XDocument.Load(ClassData.ExternalForms[listBox1.SelectedIndex]);
            //        string Name = doc.Element("Root").Element("Name").Value;
            //        bool FormExists = false;
            //        foreach (Form f in Application.OpenForms)
            //        {
            //            if (f.Text == Name)
            //            {
            //                FormExists = true;
            //                f.WindowState = FormWindowState.Normal;
            //                f.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width / 2 - f.ClientSize.Width / 2, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height / 2 - f.ClientSize.Height / 2);
            //                f.Activate();
            //            }
            //        }
            //        if (FormExists) return;
            //        XElement[] InVars = doc.Element("Root").Element("Input").Elements().ToArray();
            //        XElement[] OutVars = doc.Element("Root").Element("Output").Elements().ToArray();
            //        XAttribute[] OutVarsNames = doc.Element("Root").Element("Output").Elements().Attributes().ToArray();
            //        if (InVars.Length > 0 && OutVars.Length > 0)
            //        {
            //            Form form = new Form();
            //            form.Size = new Size(1, 1);
            //            form.StartPosition = FormStartPosition.CenterScreen;
            //            form.Text = Name;
            //            form.AutoSize = true;
            //            int MaxInLabel = 0;
            //            int MaxInTextBox = 0;
            //            for (int i = 0; i < InVars.Length; i++)
            //            {
            //                Label LabelName = new Label
            //                {
            //                    AutoSize = true,
            //                    Location = new Point(8, 8 + 26 * i),
            //                    Name = "InLabel",
            //                    Text = InVars[i].Value
            //                };
            //                form.Controls.Add(LabelName);
            //                if (LabelName.Size.Width > MaxInLabel) MaxInLabel = LabelName.Size.Width;
            //            }
            //            for (int i = 0; i < InVars.Length; i++)
            //            {
            //                TextBox TextBox = new TextBox
            //                {
            //                    Size = new Size(100, 20),
            //                    Location = new Point(MaxInLabel + 16, 5 + 26 * i),
            //                    Name = "InTextBox" + i.ToString(),
            //                    Text = ""
            //                };
            //                form.Controls.Add(TextBox);
            //                if (TextBox.Location.X + TextBox.Size.Width > MaxInTextBox) MaxInTextBox = TextBox.Location.X + TextBox.Size.Width;
            //            }
            //            for (int i = 0; i < OutVars.Length; i++)
            //            {
            //                string OutVarName;
            //                if (OutVarsNames.Length > i && !String.IsNullOrEmpty(OutVarsNames[i].Value))
            //                {
            //                    OutVarName = OutVarsNames[i].Value + ":";
            //                }
            //                else
            //                {
            //                    OutVarName = String.Format("{0} {1}:", ClassData.lang_current["Result"], (i + 1).ToString());
            //                }
            //                Label LabelName = new Label
            //                {
            //                    AutoSize = true,
            //                    Location = new Point(MaxInTextBox + 16, 8 + 26 * i),
            //                    Name = "OutLabel",
            //                    Text = OutVarName
            //                };
            //                form.Controls.Add(LabelName);
            //                Label OutVar = new Label
            //                {
            //                    AutoSize = true,
            //                    Location = new Point(LabelName.Location.X + LabelName.Width + 8, 8 + 26 * i),
            //                    Name = "OutVar" + i.ToString(),
            //                    Text = ""
            //                };
            //                form.Controls.Add(OutVar);
            //                Label Formula = new Label
            //                {
            //                    Visible = false,
            //                    Name = "Formula" + i.ToString(),
            //                    Text = OutVars[i].Value.ToString()
            //                };
            //                form.Controls.Add(Formula);
            //            }
            //            Button ButtonCalc = new Button
            //            {
            //                AutoSize = true,
            //                Name = "ButtonCalc",
            //                Text = ClassData.lang_current["Calculate"]
            //            };
            //            if (InVars.Length > OutVars.Length) ButtonCalc.Location = new Point(form.Width / 2 - ButtonCalc.Width / 2, 16 + 26 * InVars.Length);
            //            else ButtonCalc.Location = new Point(form.Width / 2 - ButtonCalc.Width / 2, 16 + 26 * InVars.Length);
            //            form.Controls.Add(ButtonCalc);
            //            if (ButtonCalc.Location.Y > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height - System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height / 10)
            //            {
            //                form.AutoScroll = true;
            //                form.Size = new Size(form.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height - System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height / 10);
            //            }
            //            ButtonCalc.Click += ClassFunctions.CalcClick;
            //            form.Show();
            //        }
            //        else MessageBox.Show("Reading file error", "Warning");
            //    }
        }

    public void btnSettings_Click(object sender, EventArgs e)
        {
            ClassData.SettingsWindow.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(listBox1.SelectedIndex);
            if (index == -1)
                btnSelect.Enabled = false;
            else
                btnSelect.Enabled = true;
        }

        //private void UpdateCheck()
        //{
        //    try
        //    {
        //        WebClient FirstWebClient = new WebClient();
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        //        Stream FirstStream = FirstWebClient.OpenRead(ClassData.UpdateInfoLink);
        //        StreamReader FirstSR = new StreamReader(FirstStream);
        //        string[] InfoLines = new string[0];
        //        string TempLine = string.Empty;
        //        string NewVersion = string.Empty;
        //        while ((TempLine = FirstSR.ReadLine()) != null)
        //        {
        //            Array.Resize(ref InfoLines, InfoLines.Length + 1);
        //            InfoLines[InfoLines.Length - 1] = TempLine;
        //            if (InfoLines[InfoLines.Length - 1].Contains("Version"))
        //            {
        //                FirstStream.Close();
        //                NewVersion = InfoLines[InfoLines.Length - 1].Split('=')[1];
        //                break;
        //            }
        //        }
        //        FirstStream.Close();
        //        if (NewVersion == string.Empty) CouldntUpdate("Отсутствует упоминание версии");
        //        string[] LocalVersionArray = ClassData.Version.Split('.').ToArray();
        //        string[] NewVersionArray = NewVersion.Split('.').ToArray();
        //        bool NeedToUpdate = false;
        //        if (Int32.Parse(LocalVersionArray[0]) < Int32.Parse(NewVersionArray[0]))
        //        {
        //            NeedToUpdate = true;
        //        }
        //        else if (Int32.Parse(LocalVersionArray[0]) == Int32.Parse(NewVersionArray[0]))
        //        {
        //            if (Int32.Parse(LocalVersionArray[1]) < Int32.Parse(NewVersionArray[1])) NeedToUpdate = true;
        //        }
        //        if (NeedToUpdate)
        //        {
        //            if (!File.Exists(ClassData.ApplicationFolder + "\\" + "Updater.exe")) FirstWebClient.DownloadFile(ClassData.UpdaterLink, ClassData.ApplicationFolder + "\\" + "Updater.exe");
        //            ProcessStartInfo StartInfo = new ProcessStartInfo(ClassData.ApplicationFolder + "\\" + "Updater.exe");
        //            StartInfo.Arguments = ClassData.UpdateDownloadLink + " " + ClassData.UpdateInfoLink + " " + Application.ExecutablePath;
        //            Process Updater = new Process();
        //            Updater.StartInfo = StartInfo;
        //            Updater.Start();
        //            Environment.Exit(0);
        //        }
        //        FirstWebClient.Dispose();
        //    }
        //    catch (System.Net.WebException e)
        //    {
        //        MessageBox.Show(e.Message, "Не удалось произвести обновление");
        //        Environment.Exit(0);
        //    }
        //}

        private static void CouldntUpdate(string msg)
        {
            MessageBox.Show(msg, "Не удалось произвести обновление");
            Environment.Exit(0);
        }

        private void New_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassData.AddNew.Show();
        }

        private void DeleteCurrent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ClassData.ExternalForms.ContainsKey(listBox1.SelectedIndex)) return;
            XDocument doc = XDocument.Load(ClassData.ExternalForms[listBox1.SelectedIndex]);
            string Name = doc.Element("Root").Element("Name").Value;
            DialogResult dialogResult = MessageBox.Show($"Удалить {Name}?" , "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(ClassData.ExternalForms[listBox1.SelectedIndex]);
                //ClassFunctions.FillMainForm();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
