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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormUI_Shown(object sender, EventArgs e)
        {
            //treeView1.BeginUpdate();
            FillTreeView();
            treeView1.ImageList = new ImageList();
            //if (File.Exists("Smithy's_Hammer.png")) treeView1.ImageList.Images.Add(Image.FromFile("Smithy's_Hammer.png"));
            //if (File.Exists("Bar_of_Wrought_Iron.png")) treeView1.ImageList.Images.Add(Image.FromFile("Bar_of_Wrought_Iron.png"));
            treeView1.Nodes[0].ImageIndex = 0;
            treeView1.Nodes[1].ImageIndex = 1;
            treeView1.ImageIndex = 1;
            this.Activate();
        }

        private void FormUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FillTreeView()
        {
            treeView1.Nodes.Clear();
            ClassData.FormNumbers.Clear();
            int count = 0;
            foreach (Form f in ClassData.InternalForms.Keys)
            {
                treeView1.Nodes.Add(ClassData.InternalForms[f][0]);
                ClassData.FormNumbers.Add(count++, f);
            }
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (treeView1.SelectedNode.Text == null) return;
            string selectedItem = treeView1.SelectedNode.Text.ToString();
            if (ClassData.FormNumbers.ContainsKey(treeView1.SelectedNode.Index))
            {
                Form c = ClassData.FormNumbers[treeView1.SelectedNode.Index];
                c.StartPosition = FormStartPosition.CenterScreen;
                if (c.Visible)
                {
                    c.WindowState = FormWindowState.Normal;
                    c.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width / 2 - c.ClientSize.Width / 2, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height / 2 - c.ClientSize.Height / 2);
                    c.Activate();
                }
                if (!c.Visible & c != null)
                {
                    c.Show();
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == null) return;
            treeView1.Nodes[treeView1.SelectedNode.Index].SelectedImageIndex = treeView1.SelectedNode.Index;
        }
    }
}
