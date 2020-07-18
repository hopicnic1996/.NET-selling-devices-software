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
using System.IO;

namespace Libarian_Management.Screens
{
    public partial class AddForm : TemplateForm
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techShopDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.techShopDataSet.Category);
                btUpdate.Hide();
                btSave.Hide();
            tbImageLoad.Visible = false;
            if(DashBoardForm.forFun == 1)
            {
                btSave.Show();
            }else if(DashBoardForm.forFun == 2)
            {
                cbType.Text = DashBoardForm.getCatName;
                LoadInfor();
                btUpdate.Show();
            }

        }

        private void LoadInfor()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String query = "Select * from Products where proId = '" + DashBoardForm.getProId + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    tbProName.Text = (reader["proName"].ToString());
                    tbQuantity.Text = (reader["proQuantity"].ToString());
                    tbPrice.Text = (reader["proPrice"].ToString());
                    byte[] imgg = (byte[])(reader["proImage"]);
                    if(imgg == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                tbImageLoad.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            if (tbImageLoad.Text == "")
            {
                MessageBox.Show("Please add picture");
            }
            else
            {
                FileStream fstream = new FileStream(this.tbImageLoad.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);

                SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
                String query = "Insert into Products(catId, proName, proQuantity, proPrice, proImage) values('" + this.cbType.SelectedValue + "','" + this.tbProName.Text + "','" + this.tbQuantity.Text + "','" + this.tbPrice.Text + "',@IMG);";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd1.Parameters.Add(new SqlParameter("@IMG", imageBt));
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Saved");
                    this.Close();
                    DashBoardForm.forFun = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String getquery = "Select catName from Category";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(getquery, conn);
            sda.Fill(dt);
            cbType.DataSource = dt;*/
/*            SqlCommand cmd = new SqlCommand(getquery, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string cCatId = reader.GetInt32("catId").ToString();
                    string cName = reader.GetString("catName");
                }
            }*/
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=trung;Initial Catalog=TechShop;Integrated Security=True");
            String query = "update Products set catId='" + this.cbType.SelectedValue + "',proName='" + this.tbProName.Text + "',proQuantity='" + this.tbQuantity.Text + "',proPrice='" + this.tbPrice.Text + "'where proId = '" + DashBoardForm.getProId + "'";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                //cmd1.Parameters.Add(new SqlParameter("@IMG", imageBt));
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
