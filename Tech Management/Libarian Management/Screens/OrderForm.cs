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
    public partial class OrderForm : TemplateForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        int selectedRow;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            loadGridView();
            disable();
            View();
        }

        private void disable()
        {
            tbOrId.Enabled = false;
            tbUserId.Enabled = false;
            tbProId.Enabled = false;
            tbQuantity.Enabled = false;
            tbPrice.Enabled = false;
            dateTimePicker1.Enabled = false;
            cbStatus.Enabled = false;
            btEdit.Enabled = false;
        }

        private void View()
        {
            if(LoginForm.role == "2")
            {
                btEdit.Visible = false;
                btDelete.Visible = false;
                btChange.Visible = false;
            }else if(LoginForm.role == "1")
            {
                btEdit.Visible = true;
                btDelete.Visible = true;
                btChange.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[selectedRow];
                /*tbOrId.Text = row.Cells["orId"].Value.ToString();
                tbUserId.Text = row.Cells["userId"].Value.ToString();
                tbProId.Text = row.Cells["proId"].Value.ToString();
                tbQuantity.Text = row.Cells["orQuantity"].Value.ToString();
                tbPrice.Text = row.Cells["price"].Value.ToString();
                dateTimePicker1.Text = row.Cells["orDate"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();*/
                tbOrId.Text = row.Cells["orId"].Value.ToString();
                tbUserId.Text = row.Cells["userName"].Value.ToString();
                tbProId.Text = row.Cells["proName"].Value.ToString();
                tbQuantity.Text = row.Cells["orQuantity"].Value.ToString();
                tbPrice.Text = row.Cells["price"].Value.ToString();
                dateTimePicker1.Text = row.Cells["orDate"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void loadGridView()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            //String qry = "select * from pOrder";
            //String qry1 = "select * from pOrder where userId ='"+LoginForm.userId+"'";
            String qry = "select * from newOrder";
            String qry1 = "select * from newOrder where userName ='"+LoginForm.nameDisplay+"'";
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            if (LoginForm.role == "1")
            {
                sda = new SqlDataAdapter(qry, conn);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }else if(LoginForm.role == "2")
            {
                sda = new SqlDataAdapter(qry1, conn);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btEdit_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            //String query = "update pOrder set Status='"+ cbStatus.Text + "'where orId = '" + tbOrId.Text + "'";
            String query = "update newOrder set Status='" + cbStatus.Text + "'where orId = '" + tbOrId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update success");
                cbStatus.Enabled = false;
                btEdit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text == "")
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                cbStatus.Enabled = true;
                btEdit.Enabled = true;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            //String query = "Delete from pOrder where orId = '" + tbOrId.Text + "'";
            String query = "Delete from newOrder where orId = '" + tbOrId.Text + "'";
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

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to cancel the order?", "Title", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                String Cancel = "Cancel!";
                SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
                //String query = "update pOrder set Status='" + Cancel + "'where orId = '" + tbOrId.Text + "'";
                String query = "update newOrder set Status='" + Cancel + "'where orId = '" + tbOrId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cancel success");
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
