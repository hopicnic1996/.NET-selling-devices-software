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
    public partial class AddUserForm : TemplateForm
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            loadComboBox();
            register();
        }

        private void loadComboBox()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String query = "Select * from Roles";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbUserType.Items.Clear();
            cbUserType.DataSource = dt;
            cbUserType.DisplayMember = "description";
            cbUserType.ValueMember = "roleId";
            conn.Close();
        }

        private void register()
        {
            if(LoginForm.joa == 1)
            {
                label3.Visible = false;
                cbUserType.Visible = false;
                //cbUserType.ValueMember = "2";
                cbUserType.Text = "Customer";
                btAdd.Text = "Confirm";
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String query = "Select * from Users where userName = '" + tbUserName.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable result = new DataTable();
            sda.Fill(result);
            if(result.Rows.Count == 1)
            {
                MessageBox.Show("Username already used!");
            }
            else
            {
                if (tbPassword.Text.Equals(tbConfirmPassword.Text))
                {
                    String query1 = "Insert into Users values('" + tbUserName.Text.Trim() + "','"+ tbPassword.Text.Trim() + "','" + cbUserType.SelectedValue + "')";
                    SqlCommand cmd = new SqlCommand(query1, conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Add success");
                        this.Close();
                        LoginForm.joa = 0;
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Confirm password not correct!");
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.joa = 0;
        }
    }
}
