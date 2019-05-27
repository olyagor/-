namespace Курсовая
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.FileName_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfChange_listView2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDelete_listView2 = new System.Windows.Forms.Button();
            this.btnSelect_listView1 = new System.Windows.Forms.Button();
            this.btnSelect_listView2 = new System.Windows.Forms.Button();
            this.btnTransfer_listView2 = new System.Windows.Forms.Button();
            this.btnSort_SortForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList1;
            this.treeView.Location = new System.Drawing.Point(28, 60);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(278, 418);
            this.treeView.TabIndex = 1;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-жесткий-диск-16.png");
            this.imageList1.Images.SetKeyName(1, "icons8-заполненная-папка-16.png");
            this.imageList1.Images.SetKeyName(2, "icons8-открытая-папка-16.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Size,
            this.DateOfChange});
            this.listView1.Location = new System.Drawing.Point(312, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(417, 418);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 200;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 105;
            // 
            // DateOfChange
            // 
            this.DateOfChange.Text = "Date Of Change";
            this.DateOfChange.Width = 200;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName_listView2,
            this.Size_listView2,
            this.DateOfChange_listView2});
            this.listView2.Location = new System.Drawing.Point(735, 60);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(417, 418);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // FileName_listView2
            // 
            this.FileName_listView2.Text = "File Name";
            this.FileName_listView2.Width = 200;
            // 
            // Size_listView2
            // 
            this.Size_listView2.Text = "Size";
            this.Size_listView2.Width = 200;
            // 
            // DateOfChange_listView2
            // 
            this.DateOfChange_listView2.Text = "Date Of Change";
            this.DateOfChange_listView2.Width = 200;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 503);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add file(s)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete_listView2
            // 
            this.btnDelete_listView2.Location = new System.Drawing.Point(735, 503);
            this.btnDelete_listView2.Name = "btnDelete_listView2";
            this.btnDelete_listView2.Size = new System.Drawing.Size(113, 34);
            this.btnDelete_listView2.TabIndex = 5;
            this.btnDelete_listView2.Text = "Delete file(s)";
            this.btnDelete_listView2.UseVisualStyleBackColor = true;
            this.btnDelete_listView2.Click += new System.EventHandler(this.btnDelete_listView2_Click);
            // 
            // btnSelect_listView1
            // 
            this.btnSelect_listView1.Location = new System.Drawing.Point(312, 503);
            this.btnSelect_listView1.Name = "btnSelect_listView1";
            this.btnSelect_listView1.Size = new System.Drawing.Size(131, 34);
            this.btnSelect_listView1.TabIndex = 6;
            this.btnSelect_listView1.Text = "Select all";
            this.btnSelect_listView1.UseVisualStyleBackColor = true;
            this.btnSelect_listView1.Click += new System.EventHandler(this.btnSelect_listView1_Click);
            // 
            // btnSelect_listView2
            // 
            this.btnSelect_listView2.Location = new System.Drawing.Point(870, 503);
            this.btnSelect_listView2.Name = "btnSelect_listView2";
            this.btnSelect_listView2.Size = new System.Drawing.Size(112, 34);
            this.btnSelect_listView2.TabIndex = 7;
            this.btnSelect_listView2.Text = "Select all";
            this.btnSelect_listView2.UseVisualStyleBackColor = true;
            this.btnSelect_listView2.Click += new System.EventHandler(this.btnSelect_listView2_Click);
            // 
            // btnTransfer_listView2
            // 
            this.btnTransfer_listView2.Location = new System.Drawing.Point(994, 503);
            this.btnTransfer_listView2.Name = "btnTransfer_listView2";
            this.btnTransfer_listView2.Size = new System.Drawing.Size(131, 34);
            this.btnTransfer_listView2.TabIndex = 8;
            this.btnTransfer_listView2.Text = "Transfer files";
            this.btnTransfer_listView2.UseVisualStyleBackColor = true;
            this.btnTransfer_listView2.Click += new System.EventHandler(this.btnTransfer_listView2_Click);
            // 
            // btnSort_SortForm
            // 
            this.btnSort_SortForm.Location = new System.Drawing.Point(28, 503);
            this.btnSort_SortForm.Name = "btnSort_SortForm";
            this.btnSort_SortForm.Size = new System.Drawing.Size(131, 34);
            this.btnSort_SortForm.TabIndex = 13;
            this.btnSort_SortForm.Text = "Sort files";
            this.btnSort_SortForm.UseVisualStyleBackColor = true;
            this.btnSort_SortForm.Click += new System.EventHandler(this.btnSort_SortForm_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1184, 555);
            this.Controls.Add(this.btnSelect_listView2);
            this.Controls.Add(this.btnDelete_listView2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect_listView1);
            this.Controls.Add(this.btnSort_SortForm);
            this.Controls.Add(this.btnTransfer_listView2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Helper";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader DateOfChange;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader FileName_listView2;
        private System.Windows.Forms.ColumnHeader Size_listView2;
        private System.Windows.Forms.ColumnHeader DateOfChange_listView2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDelete_listView2;
        private System.Windows.Forms.Button btnSelect_listView1;
        private System.Windows.Forms.Button btnSelect_listView2;
        private System.Windows.Forms.Button btnTransfer_listView2;
        private System.Windows.Forms.Button btnSort_SortForm;
    }
}

