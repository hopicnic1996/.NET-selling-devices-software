using Libarian_Management.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Libarian_Management.Screens
{
    public partial class LoginForm : TemplateForm
    {
        public LoginForm()
        {
            InitializeComponent();
            UserNameTextBox.Focus();
        }
        public static int joa { get; set; }

        public static string role { get; set; }
        public static string username;
        public static string nameDisplay
        {
            get { return username; }
            set { username = value; }
        }

        public static string userId { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String query = "Select * from Users where userName = '"+UserNameTextBox.Text.Trim()+"' and password ='"+PasswordTextBox.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable result = new DataTable();
            sda.Fill(result);
            if (IsFormValid())
            {
                if (result.Rows.Count == 1)
                {
                    userId = result.Rows[0][0].ToString();
                    role = result.Rows[0][3].ToString();
                    nameDisplay = UserNameTextBox.Text;
                    this.Hide();
                    DashBoardForm db = new DashBoardForm();
                    db.Show();
                }
                else
                {
                    MessageBox.Show("User name/Password is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserNameTextBox.Focus();
                }
            }
        }

        private bool IsFormValid()
        {
            if(UserNameTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("User name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
                return false;
            }

            if (PasswordTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            joa = 0;
        }

        private void lbJoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            joa = 1;
            AddUserForm auf = new AddUserForm();
            auf.Text = "Register";
            auf.Show();
        }
    }
}
