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

namespace Курсовая
{
    public partial class Organize_files : Form
    {
        public Organize_files()
        {
            InitializeComponent();
        }



        private void btnList_Click(object sender, EventArgs e)
        {
            lvwFiles.Items.Clear();

            string[] filenames = Directory.GetFiles(txtDirectory.Text);
            if (filenames.Length == 0) return;
            Array.Sort(filenames);

            int index = int.Parse(txtStartAt.Text);
            string format = "{0:D" + txtStartAt.Text.Length.ToString() + "}";
            string base_name = txtBaseName.Text;
            List<string> old_names = new List<string>();

            foreach (string filename in filenames)
            {
                string old_name = Path.GetFileName(filename);
                old_names.Add(old_name);
                ListViewItem item = lvwFiles.Items.Add(old_name);

                string new_name =
                    base_name +
                    string.Format(format, index) +
                    Path.GetExtension(filename);

                if (old_names.Contains(new_name))
                {
                    MessageBox.Show("Name " + new_name + " is already in use.");
                    break;
                }

                item.SubItems.Add(new_name);
                index++;
            }

            lvwFiles.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwFiles.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            btnRename.Enabled = true;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            lvwFiles.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvwFiles.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string dirname = txtDirectory.Text;
            foreach (ListViewItem item in lvwFiles.Items)
            {
                string old_name = Path.Combine(dirname, item.Text);
                string new_name = Path.Combine(dirname, item.SubItems[1].Text);
                File.Move(old_name, new_name);
            }

            int num_files = lvwFiles.Items.Count;
            lvwFiles.Items.Clear();
            btnRename.Enabled = false;
            MessageBox.Show("Renamed " +
                num_files.ToString() + " files.");
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnRename.Enabled = false;
            lvwFiles.Items.Clear();   
        }

        
        private void btnPickDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                fbdDirectory.SelectedPath = txtDirectory.Text;
            }
            catch
            {
            }

            if (fbdDirectory.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = fbdDirectory.SelectedPath;
            }
        }

        private void txtStartAt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void Organize_files_Load(object sender, EventArgs e)
        {
            txtDirectory.Enabled = false;
        }
    }
}

