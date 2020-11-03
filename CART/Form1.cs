using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CART
{
    public partial class MainForm : Form
    {
        DataTable dt = new DataTable();
        DataTable dt_test = new DataTable();
        Tree tree;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                if (File.Exists(textBox1.Text))
                {
                    dataGridView1.DataSource = null; 
                    dt = GetDataTable(textBox1);
                    dataGridView1.DataSource = dt;
                } 
            }
        }

        private DataTable GetDataTable(TextBox textBox)
        {
            DataTable dt = new DataTable();
            var lines = File.ReadLines(textBox.Text);

            foreach (var headerLine in lines.Take(1))
                foreach (var headerItem in headerLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    dt.Columns.Add(headerItem);

            foreach (var line in lines.Skip(1))
                if (line != string.Empty)
                    dt.Rows.Add(line.Split(','));

            return dt;
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            int levels = Convert.ToInt32(numLevels.Value);
            buildTree(dt, levels);
        }

        private void buildTree(DataTable dt, int levels)
        {
            tree = new Tree(dt, levels);
            tree.Display(treeView1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
                if (File.Exists(textBox2.Text))
                {
                    dataGridView2.DataSource = null;
                    dt_test = GetDataTable(textBox2);
                    dataGridView2.DataSource = dt_test;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tree.Predict(dt_test, dataGridView2, label3);
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(Parent, "HelpFile.chm");
        }
    }
}
