namespace Libarian_Management.Screens
{
    partial class DashBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbAddNewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddCategory = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateCategory = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techShopDataSet = new Libarian_Management.TechShopDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.categoryTableAdapter = new Libarian_Management.TechShopDataSetTableAdapters.CategoryTableAdapter();
            this.btPurchase = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbProducts = new System.Windows.Forms.TabPage();
            this.btManageOrder = new System.Windows.Forms.Button();
            this.llCategoryRefresh = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserName});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUserName
            // 
            this.tsmiUserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiUserName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.tsmiUserName.Name = "tsmiUserName";
            this.tsmiUserName.Size = new System.Drawing.Size(12, 20);
            this.tsmiUserName.Click += new System.EventHandler(this.tsmiUserName_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDelete,
            this.tsbUpdate,
            this.tsbAdd,
            this.tsbAddNewUser,
            this.toolStripSeparator1,
            this.tsbAddCategory,
            this.tsbUpdateCategory,
            this.tsbDeleteCategory,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDelete.Image = global::Libarian_Management.Properties.Resources.delete_file_icon;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbUpdate.Image = global::Libarian_Management.Properties.Resources.edit_icon;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(65, 22);
            this.tsbUpdate.Text = "Update";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAdd.Image = global::Libarian_Management.Properties.Resources.Add_Folder_icon;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbAddNewUser
            // 
            this.tsbAddNewUser.Image = global::Libarian_Management.Properties.Resources.add_contact_icon;
            this.tsbAddNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNewUser.Name = "tsbAddNewUser";
            this.tsbAddNewUser.Size = new System.Drawing.Size(100, 22);
            this.tsbAddNewUser.Text = "Add new User";
            this.tsbAddNewUser.Click += new System.EventHandler(this.tsbAddNewUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddCategory
            // 
            this.tsbAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddCategory.Image")));
            this.tsbAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddCategory.Name = "tsbAddCategory";
            this.tsbAddCategory.Size = new System.Drawing.Size(100, 22);
            this.tsbAddCategory.Text = "Add Category";
            this.tsbAddCategory.Click += new System.EventHandler(this.tsbAddCategory_Click);
            // 
            // tsbUpdateCategory
            // 
            this.tsbUpdateCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateCategory.Image")));
            this.tsbUpdateCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateCategory.Name = "tsbUpdateCategory";
            this.tsbUpdateCategory.Size = new System.Drawing.Size(114, 22);
            this.tsbUpdateCategory.Text = "Update category";
            this.tsbUpdateCategory.Click += new System.EventHandler(this.tsbUpdateCategory_Click);
            // 
            // tsbDeleteCategory
            // 
            this.tsbDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteCategory.Image")));
            this.tsbDeleteCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteCategory.Name = "tsbDeleteCategory";
            this.tsbDeleteCategory.Size = new System.Drawing.Size(109, 22);
            this.tsbDeleteCategory.Text = "Delete category";
            this.tsbDeleteCategory.Click += new System.EventHandler(this.tsbDeleteCategory_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource1, "catId", true));
            this.listBox1.DataSource = this.categoryBindingSource;
            this.listBox1.DisplayMember = "catName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 134);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "catId";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.techShopDataSet;
            // 
            // techShopDataSet
            // 
            this.techShopDataSet.DataSetName = "TechShopDataSet";
            this.techShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.techShopDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 290);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // btPurchase
            // 
            this.btPurchase.Location = new System.Drawing.Point(713, 388);
            this.btPurchase.Name = "btPurchase";
            this.btPurchase.Size = new System.Drawing.Size(75, 23);
            this.btPurchase.TabIndex = 5;
            this.btPurchase.Text = "Order";
            this.btPurchase.UseVisualStyleBackColor = true;
            this.btPurchase.Click += new System.EventHandler(this.btPurchase_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbProducts);
            this.tabControl1.Location = new System.Drawing.Point(181, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 316);
            this.tabControl1.TabIndex = 6;
            // 
            // tbProducts
            // 
            this.tbProducts.Controls.Add(this.dataGridView1);
            this.tbProducts.Location = new System.Drawing.Point(4, 22);
            this.tbProducts.Name = "tbProducts";
            this.tbProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbProducts.Size = new System.Drawing.Size(599, 290);
            this.tbProducts.TabIndex = 0;
            this.tbProducts.Text = "Products";
            this.tbProducts.UseVisualStyleBackColor = true;
            // 
            // btManageOrder
            // 
            this.btManageOrder.Location = new System.Drawing.Point(22, 234);
            this.btManageOrder.Name = "btManageOrder";
            this.btManageOrder.Size = new System.Drawing.Size(121, 50);
            this.btManageOrder.TabIndex = 7;
            this.btManageOrder.Text = "Manage Order";
            this.btManageOrder.UseVisualStyleBackColor = true;
            this.btManageOrder.Click += new System.EventHandler(this.btManageOrder_Click);
            // 
            // llCategoryRefresh
            // 
            this.llCategoryRefresh.AutoSize = true;
            this.llCategoryRefresh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llCategoryRefresh.Location = new System.Drawing.Point(116, 216);
            this.llCategoryRefresh.Name = "llCategoryRefresh";
            this.llCategoryRefresh.Size = new System.Drawing.Size(44, 13);
            this.llCategoryRefresh.TabIndex = 8;
            this.llCategoryRefresh.TabStop = true;
            this.llCategoryRefresh.Text = "Refresh";
            this.llCategoryRefresh.Visible = false;
            this.llCategoryRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCategoryRefresh_LinkClicked);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llCategoryRefresh);
            this.Controls.Add(this.btManageOrder);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btPurchase);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "DashBoardForm";
            this.ShowInTaskbar = true;
            this.Text = "DashBoardForm";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbProducts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserName;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private TechShopDataSet techShopDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private TechShopDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbAddNewUser;
        private System.Windows.Forms.Button btPurchase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbProducts;
        private System.Windows.Forms.Button btManageOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddCategory;
        private System.Windows.Forms.ToolStripButton tsbUpdateCategory;
        private System.Windows.Forms.ToolStripButton tsbDeleteCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel llCategoryRefresh;
    }
}