using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace HHCalculator
{
    internal class ClassFunctions
    {
        public static double Calculating(string formula)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), formula);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        public static void CalcClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                Form f = button.FindForm();
                for (int i = 0; i < f.Controls.Find("OutLabel", true).Length; i++)
                {
                    string formula = f.Controls["Formula" + i.ToString()].Text;
                    for (int l = 0; l < f.Controls.Find("InLabel", true).Length; l++)
                    {
                        if (string.IsNullOrEmpty(f.Controls["InTextBox" + l.ToString()].Text)) return;
                        if (!Int32.TryParse(f.Controls["InTextBox" + l.ToString()].Text, out int result)) return;
                        formula = formula.Replace("v" + (l + 1).ToString(), f.Controls["InTextBox" + l.ToString()].Text);
                    }
                    f.Controls["OutVar" + i.ToString()].Text = ClassFunctions.Calculating(formula).ToString();
                }
            }
        }
        //public static void FillMainForm()
        //{
        //    ListBox lb = Program.MainForm.listBox1;
        //    lb.Items.Clear();
        //    ClassData.ExternalForms.Clear();
        //    if (Directory.Exists(ClassData.UserFormsPath) && System.IO.Directory.GetDirectories(ClassData.UserFormsPath).Length + System.IO.Directory.GetFiles(ClassData.UserFormsPath).Length > 0)
        //    {
        //        lb.Items.Add("    ---- Встроенные ----");
        //        lb.Items.AddRange(ClassData.InternalForms.Keys.ToArray());
        //        lb.Items.Add("    ---- Пользовательские ----");
        //        ClassFunctions.FillWithExternal(lb);
        //    }
        //    else
        //    {
        //        lb.Items.AddRange(ClassData.InternalForms.Keys.ToArray());
        //    }
        //}

        public static void FillWithExternal(ListBox lb)
        {
            string[] ExternalNames = Directory.GetFiles(ClassData.UserFormsPath, "*.xml");
            if (ExternalNames.Length > 0)
            {
                foreach (string s0 in ExternalNames)
                {
                    XDocument doc = XDocument.Load(s0);
                    XElement Name = doc.Element("Root").Element("Name");
                    if (Name != null)
                    {
                        if (!ClassData.ExternalForms.ContainsKey(Convert.ToInt32(lb.Items.Count))) ClassData.ExternalForms.Add(Convert.ToInt32(lb.Items.Count), s0);
                        lb.Items.Add(Name.Value);
                    }
                }
            }
        }
        public static bool FormulaCheck(string formula, int VarNumber)
        {
            if (!(formula == ""))
            {
                int open = 0;
                int close = 0;
                foreach (char c in formula)
                {
                    if (c == '(') open++;
                    if (c == ')') close++;
                }
                if (open == close)
                {
                    if ("v(123456789".Contains(formula[0]))
                    {
                        bool result = true;
                        for (int i = 0; i < formula.Length; i++)
                        {
                            if (("v".Contains(formula[i]) && formula.Length > i + 1 && "123456789".Contains(formula[i + 1])) | ("(".Contains(formula[i]) && formula.Length > i + 1 && "v(123456789".Contains(formula[i + 1])) | ("+-*/".Contains(formula[i]) && formula.Length > i + 1 && "v(123456789".Contains(formula[i + 1])) | "0123456789)".Contains(formula[i])) { }
                            else
                            {
                                MessageBox.Show("Error_3 in Formula " + VarNumber.ToString() + "\nFormula reading error", "Warning");
                                return false;
                            }
                        }
                        return result;
                    }
                    else
                    {
                        MessageBox.Show("Error_2 in Formula " + VarNumber.ToString() + "\nThe first symbol of the formula is incorrect", "Warning");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Error_1 in Formula " + VarNumber.ToString() + "\nCount of \"(\" and \")\" not equal", "Warning");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error_0 in Formula " + VarNumber.ToString() + "\nEmpty field", "Warning");
                return false;
            }
        }
        public static void CreateNewFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("version=" + ClassData.Version);
                string[] keys = ClassData.Variables.Keys.ToArray();
                for (int i = 0; i < keys.Length; i++)
                {
                    sw.WriteLine(keys[i] + "=0");
                }
            }
        }

        public static void RewriteFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("version=" + ClassData.Version);
                string[] keys = ClassData.Variables.Keys.ToArray();
                for (int i = 0; i < keys.Length; i++)
                {
                    sw.WriteLine(keys[i] + "=" + ClassData.Qualities[keys[i]]);
                }
            }
        }

        public static Dictionary<string, double> ReadUserQualities(string filePath)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            string[] lines = File.ReadAllLines(filePath);
            string[] temp = new string[2];
            double value;
            foreach (string line in lines)
            {
                temp = line.Split('=');
                try
                {
                    value = double.Parse(temp[1]);
                    result.Add(temp[0], value);
                }
                catch (FormatException e)
                {
                    throw e;
                }
            }
            return result;
        }

        public static void UpdateQualitiesDict(Dictionary<string, double> newQualities)
        {
            foreach (string key in ClassData.Qualities.Keys)
            {
                if (newQualities.ContainsKey(key))
                {
                    ClassData.Qualities[key] = newQualities[key];
                }
            }
        }

        public static void FillList(ListBox listbox)
        {
            listbox.Items.Clear();
            string[] keys = ClassData.Variables.Keys.ToArray();
            for (int i = 0; i < keys.Length; i++)
            {
                listbox.Items.Add(ClassData.Variables[keys[i]] + " = " + ClassData.Qualities[keys[i]]);
            }
        }

        public static void CreateConvertVariables()
        {
            string[] variables = ClassData.Variables.Keys.ToArray();
            for (int i = 0; i < variables.Length; i++)
            {
                ClassData.ConvertVariables.Add(ClassData.Variables[variables[i]], variables[i]);
            }
        }

        public static void Edit(string Name, int NewQuality)
        {
            ClassData.Qualities[ClassData.ConvertVariables[Name]] = NewQuality;
        }
    }
}
