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
using System.Diagnostics;

namespace Курсовая
{
    public partial class Main_Form : Form
    {
        private string full_path;
        
        public Main_Form()
        {
            InitializeComponent();
            DriveTree();
        }

        public List<FilePath> Files = new List<FilePath>();

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            full_path = selectedNode.FullPath;

            DirectoryInfo di = new DirectoryInfo(full_path);
            FileInfo[] fiArray;
            DirectoryInfo[] diArray;

            try
            {
                fiArray = di.GetFiles();
                diArray = di.GetDirectories();
            }
            catch
            {
                return;
            }

            listView1.Items.Clear();

            foreach (DirectoryInfo dirInfo in diArray)
            {
                ListViewItem lvi = new ListViewItem(dirInfo.Name);
                lvi.SubItems.Add("0");
                lvi.SubItems.Add(dirInfo.LastWriteTime.ToString());
                lvi.ImageIndex = 0;

                listView1.Items.Add(lvi);
            }


            foreach (FileInfo fileInfo in fiArray)
            {
                ListViewItem lvi = new ListViewItem(fileInfo.Name);
                lvi.SubItems.Add(fileInfo.Length.ToString());
                lvi.SubItems.Add(fileInfo.LastWriteTime.ToString());

                string filenameExtension =
                  Path.GetExtension(fileInfo.Name).ToLower();

                listView1.Items.Add(lvi);
                listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                btnAdd.Enabled = true;
                btnSelect_listView1.Enabled = true;
            }
        }


        public void DriveTree()
        {
            string[] logical_drives_array = Directory.GetLogicalDrives();
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            foreach (string str in logical_drives_array)
            {
                TreeNode drive = new TreeNode(str, 0, 0);
                treeView.Nodes.Add(drive);
                GetDirs(drive);
            }
            treeView.EndUpdate();
        }

        public void GetDirs(TreeNode node)
        {
            DirectoryInfo[] directory_array;
            node.Nodes.Clear();
            string full_path = node.FullPath;
            DirectoryInfo directory = new DirectoryInfo(full_path);
            try
            {
                directory_array = directory.GetDirectories();
            }
            catch
            {
                return;
            }
            foreach (DirectoryInfo dirinfo in directory_array)
            {
                TreeNode dir = new TreeNode(dirinfo.Name, 1, 2);
                node.Nodes.Add(dir);
            }
        }

        //раскрытие узлов 
        private void treeView1_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            treeView.BeginUpdate();

            foreach (TreeNode node in e.Node.Nodes)
            {
                GetDirs(node);
            }
            treeView.EndUpdate();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CopySelectedItems(listView1, listView2);
            listView2.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            btnDelete_listView2.Enabled = true;
            btnSelect_listView2.Enabled = true;
            btnTransfer_listView2.Enabled = true;
        }
        private void CopySelectedItems(ListView source, ListView target)
        {
            foreach (ListViewItem item in source.SelectedItems)
            {
                Files.Add(new FilePath() { Path = treeView.SelectedNode.FullPath, Item = (ListViewItem)item.Clone()});
            }

            UpdateSelectedItems(target);
        }

        private void UpdateSelectedItems(ListView target)
        {
            target.Items.Clear();

            foreach(FilePath file in Files)
            {
                target.Items.Add(file.Item);
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnSelect_listView1.Enabled = false;
            btnDelete_listView2.Enabled = false;
            btnSelect_listView2.Enabled = false;
            btnTransfer_listView2.Enabled = false;
        }

        private void btnDelete_listView2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                FilePath file = Files.Find(x => x.Item == item);
                Files.Remove(file);
            }

            UpdateSelectedItems(listView2);
        }

        
        private void btnSelect_listView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Selected = true;
            }
        }

        private void btnSelect_listView2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                item.Selected = true;
            }
        }
              
        private void btnTransfer_listView2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    FilePath file = Files.Find(x => x.Item == item);
                    string fileSource = Path.Combine(file.Path, item.Text);
                    string fileDestination = Path.Combine(folderBrowserDialog1.SelectedPath, item.Text);

                    if (!File.Exists(fileSource))
                        return;
                    File.Copy(fileSource, fileDestination, true);
                }
            }
        }
        
        private void btnSort_SortForm_Click(object sender, EventArgs e)
        {
            Organize_files f2 = new Organize_files();
            f2.Show();
        }

        
    }
}

