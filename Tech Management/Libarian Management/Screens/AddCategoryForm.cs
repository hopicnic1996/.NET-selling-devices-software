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
    public partial class AddCategoryForm : TemplateForm
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            btAddCategory.Hide();
            btUpdate.Hide();
            if (DashBoardForm.forFun == 1)
            {
                btAddCategory.Show();
            }
            else if (DashBoardForm.forFun == 2)
            {
                LoadInfor();
                btUpdate.Show();
            }
        }

        private void LoadInfor()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String query = "select * from Category where catId ='" + DashBoardForm.getCatId.ToString() +"';";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tbCategoryName.Text = (reader["catName"].ToString());
                    tbDescription.Text = (reader["catDescription"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddCategory_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String query = "Insert into Category values('" + tbCategoryName.Text + "','" + tbDescription.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable result = new DataTable();
            sda.Fill(result);
            SqlCommand cmd = new SqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Add success");
                        this.Close();
                DashBoardForm.forFun = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String query = "update Category set catName='" + this.tbCategoryName.Text + "',catDescription='" + this.tbDescription.Text + "'where catId = '" + DashBoardForm.getCatId + "'";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Update success");
                this.Close();
                DashBoardForm.forFun = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
