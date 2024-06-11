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

namespace WholeSaleManagementSystem
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }
        private void Maximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1SL8C9\\SQLEXPRESS;Initial Catalog=WholeSaleManagementStudio;Integrated Security=True");
        private void insert_Data()
        {
            if (txtBoxName.Text != "" || textBoxQuant.Text != "" || comboBoxCat.Text != "" || txtBoxPrice.Text != "")
            {
                con.Open();
                string query = "insert into Product values('" + txtBoxName.Text  + "', '" + txtBoxPrice.Text + "', '" + textBoxQuant.Text + "','" + comboBoxCat.Text + "', '" +expiryDtp.Value.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0) MessageBox.Show("Insertion is successfull.");
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
            }
            else MessageBox.Show("Please enter values! The fields are empty!!");
        }
        private void populate(string list)
        {
            string expire_date = "";
            string query = "";
            if (list == "red")
            {
                expire_date = DateTime.Now.AddDays(10).ToShortDateString();
                query = "select * from Product where expire_date<='" + expire_date + "'";
            }
            else if (list == "green")
            {
                expire_date = DateTime.Now.AddDays(10).ToShortDateString();
                query = "select * from Product where expire_date>'" + expire_date + "'";
            }
            else if (list == "expired")
            {
                expire_date = DateTime.Now.ToShortDateString();
                query = "select * from Product where expire_date<'" + expire_date + "'";
            }
            else if (list == "not-expired")
            {
                expire_date = DateTime.Now.ToShortDateString();
                query = "select * from Product where expire_date>='" + expire_date + "'";
            }
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            proDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Product";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            proDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        void clear()
        {
            txtBoxName.Text = "";
            txtBoxPrice.Text = "";
            textBoxQuant.Text = "";
        }
        private void Add_Click(object sender, EventArgs e)
        {
            insert_Data();
            clear();
            populate();

        }
        void load_catagory_comboBox()
        {
            con.Open();
            string query = "select name from Product_Category";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comboBoxCat.Items.Add(row["name"].ToString());
            }
        }
        private void ManageProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wholeSaleManagementStudioDataSet9.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter1.Fill(this.wholeSaleManagementStudioDataSet9.Product);
            cbSelectColumn.SelectedIndex = 0;
            populate();
            load_catagory_comboBox();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string searchData = textBoxSearch.Text;
            string query = "select * from Product ";
            if (cbSelectColumn.SelectedIndex == 0)
            {
                query += "where proName like '%" + searchData + "%' or proPrice like '%" + searchData + "%' or proQuantity like '%" + searchData + "%' or proCategory like '%" + searchData + "%' or proID like '%" + searchData + "%'";
            }
            else
            {
                if (cbSelectColumn.SelectedIndex == 1 && searchData.Length > 0)
                {
                    if (int.TryParse(searchData, out _))
                        query += "where ProID like '%" + searchData + "%'";
                }
                else if (cbSelectColumn.SelectedIndex == 2)
                {
                    query += "where ProName like '%" + searchData + "%'";
                }
                else if (cbSelectColumn.SelectedIndex == 3)
                {
                    query += "where ProPrice like '%" + searchData + "%'";
                }
                else if (cbSelectColumn.SelectedIndex == 4)
                {
                    query += "where ProCategory like '%" + searchData + "%'";
                }
            }

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable("Sellers");
            sda.Fill(dt);
            proDGV.DataSource = dt;
            con.Close();
        }

        private void proDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.proDGV.Rows[e.RowIndex];
                txtBoxId.Text = row.Cells["proID"].Value.ToString();
                txtBoxName.Text = row.Cells["proName"].Value.ToString();
                textBoxQuant.Text = row.Cells["proQuantity"].Value.ToString();
                comboBoxCat.Text = row.Cells["proCategory"].Value.ToString();
                expiryDtp.Text = row.Cells["expire_date"].Value.ToString();
                txtBoxPrice.Text = row.Cells["proPrice"].Value.ToString();
            }
        }
        private void delete()
        {
            if (txtBoxName.Text != "" || textBoxQuant.Text != "" || comboBoxCat.Text != "" || txtBoxPrice.Text != "")
            {
                con.Open();
                string query = "delete from Product where proID = '" + txtBoxId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0) MessageBox.Show("Successfully deleted!");
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
            }
            else MessageBox.Show("Please enter values! The fields are empty!!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            delete();
            clear();
            txtBoxId.Text = "";
            populate();
        }

        void update()
        {
            if (txtBoxName.Text != "" || textBoxQuant.Text != "" || comboBoxCat.Text != "" || txtBoxPrice.Text != "")
            {
                con.Open();
                
                string query = "update Product set ProName = '" + txtBoxName.Text + "', ProPrice = '" + txtBoxPrice.Text + "', ProQuantity = '" + textBoxQuant.Text + "', ProCategory = '" + comboBoxCat.Text + "', expire_date = '" + expiryDtp.Value.ToString() + "' where ProID = " + txtBoxId.Text+"";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0) MessageBox.Show("update operation is successfull.");
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
            }
            else MessageBox.Show("Please enter values! The fields are empty!!");
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            update();
            populate();
            clear();
            txtBoxId.Text = "";
        }

        private void showRed_CheckedChanged(object sender, EventArgs e)
        {
            populate("red");
        }

        private void showGreen_CheckedChanged(object sender, EventArgs e)
        {
            populate("green");
        }

        private void notExpiredList_CheckedChanged(object sender, EventArgs e)
        {
            populate("not-expired");
        }

        private void expiredList_CheckedChanged(object sender, EventArgs e)
        {
            populate("expired");
        }

        private void showAll_CheckedChanged(object sender, EventArgs e)
        {
            populate();
        }
    }
}
