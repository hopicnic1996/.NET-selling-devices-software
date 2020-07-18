using Libarian_Management.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libarian_Management.Screens
{
    public partial class DashBoardForm : TemplateForm
    {
        
        public DashBoardForm()
        {
            InitializeComponent();
        }
        //Object getquery;
        String currentDate = DateTime.Now.ToString();
        DataTable dt = new DataTable();
        int selectedRow;
        public static int forFun = 0;
        public static string proName { get; set; }
        public static string proPrice { get; set; }
        public static int getforFun
        {
            get { return forFun; }
            set { forFun = value; }
        }

        public static Object getCatId { get; set; }

        public static string catname;

        public static string getCatName
        {
            get { return catname; }
            set { catname = value; }
        }
        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techShopDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.techShopDataSet.Category);
            textBox1.Text = LoginForm.role;
            textBox1.Enabled = false;
            tsmiUserName.Text = LoginForm.username;
            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;
            btPurchase.Enabled = false;
            //listBox1.SelectedIndex = 1;
            listBox1.SelectedIndex = 0;
            if (LoginForm.role == "2")
            {
                toolStrip1.Visible = false;
                btPurchase.Visible = true;
                btManageOrder.Text = "Your Order";
            }
            else if(LoginForm.role == "1")
            {
                toolStrip1.Visible = true;
                btPurchase.Visible = false;
                btManageOrder.Text = "Manage Order";
            }

        }

        private void disable()
        {
            toolStrip1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            catname = listBox1.Text;
            dt = new DataTable();
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            //getquery = listBox1.SelectedValue;
            getCatId = listBox1.SelectedValue;
            //String qry = ("select proId as 'Product ID', proName as 'Name', proQuantity as 'Quantity', proPrice as 'Price' from Products where catId = '" + getquery + "'");
            String qry = ("select proId as 'Product ID', proImage as 'Image', proName as 'Name', proQuantity as 'Quantity', proPrice as 'Price' from Products where catId = '" + getCatId + "'");
            SqlDataAdapter sda1 = new SqlDataAdapter(qry, conn);
            sda1.Fill(dt);
            dataGridView1.DataSource = dt;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda1.Update(dt);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            forFun = 1;
            AddForm af = new AddForm();
            af.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(selectedRow >= 0)
            {
                tsbUpdate.Enabled = true;
                tsbDelete.Enabled = true;
                btPurchase.Enabled = true;
                DataGridViewRow row = this.dataGridView1.Rows[selectedRow];
                //textBox1.Text = row.Cells["Product ID"].Value.ToString();
                proId = row.Cells["Product ID"].Value.ToString();
                proName = row.Cells["Name"].Value.ToString();
                proPrice = row.Cells["Price"].Value.ToString();
            }
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            if (proId != "")
            {
                forFun = 2;
                AddForm af = new AddForm();
                af.Show();

            }
            else
            {
                MessageBox.Show("Please select a product");
            }
        }

        public static string proId;

        public static string getProId
        {
            get { return proId; }
            set { proId = value; }
        }

        private void tsmiUserName_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to remove this product?", "Title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
                String query = "Delete from Products where proId ='" + proId + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btPurchase_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            //String query = "Insert into pOrder(userId, proId, orQuantity, price, orDate, Status) values('" + LoginForm.userId + "','" + getProId + "',1,'" + proPrice + "','"+ currentDate + "','Pending');";
            String query = "Insert into newOrder(userName, catName, proName, orQuantity, price, orDate, Status) values('" + LoginForm.nameDisplay + "','" + DashBoardForm.getCatName+"','" + DashBoardForm.proName + "',1,'" + proPrice + "','" + currentDate + "','Pending');";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Purchased");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btManageOrder_Click(object sender, EventArgs e)
        {
            OrderForm of = new OrderForm();
            of.Show();
        }

        private void tsbAddNewUser_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
            auf.Show();
        }

        private void tsbUpdateCategory_Click(object sender, EventArgs e)
        {
            if (getCatId != "")
            {
                forFun = 2;
                AddCategoryForm acf = new AddCategoryForm();
                acf.Show();
            }
            else
            {
                MessageBox.Show("Please select a product");
            }
        }

        private void tsbDeleteCategory_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to remove "+ getCatName +" category?", "Title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
                String query = "Delete from Category where catId = '" + getCatId + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void llCategoryRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void tsbAddCategory_Click(object sender, EventArgs e)
        {
            forFun = 1;
            AddCategoryForm acf = new AddCategoryForm();
            acf.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
