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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }
        //Mac os buttons
        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // mac os button close
        private void GoBack_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1SL8C9\\SQLEXPRESS;Initial Catalog=WholeSaleManagementStudio;Integrated Security=True");
        private void insert_Data()
        {
            if (CatNameTb.Text != "" && CatDescTb.Text != "")
            {
                con.Open();
                string query = "insert into Product_Category(Name, Description) values('" + CatNameTb.Text + "', '" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("Insertion is successfull.");
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
            }
            else MessageBox.Show("Please enter values! The fields are empty!!");
            populate();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Product_Category";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            catDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void ManageCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wholeSaleManagementStudioDataSet4.Product_Category' table. You can move, or remove it, as needed.
            //this.product_CategoryTableAdapter.Fill(this.wholeSaleManagementStudioDataSet4.Product_Category);
            populate();
            cbSelectColumn.SelectedIndex = 0;
        }

        private void CatDescTb_TextChanged(object sender, EventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
                
            //}
            
        }

        private void CatDGV_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            CatIdTb.Clear();
            CatNameTb.Clear();
            CatDescTb.Clear();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            insert_Data();
            clear();
        }

        
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string searchData = textBoxSearch.Text;
            string query = "select * from Product_Category ";
            if (cbSelectColumn.SelectedIndex == 0)
            {
                query += "where Name like '%" + searchData + "%' or Description like '%" + searchData + "%'";
                if (int.TryParse(searchData, out _))
                    query += "or ID = " + searchData;
            }
            else
            {
                if (cbSelectColumn.SelectedIndex == 1 && searchData.Length > 0)
                {
                    if (int.TryParse(searchData, out _))
                        query += "where ID = " + searchData;
                }
                else if (cbSelectColumn.SelectedIndex == 2)
                {
                    query += "where Name like '%" + searchData + "%'";
                }
            }

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            DataTable dt = new DataTable("Sellers");
            sda.Fill(dt);
            catDGV.DataSource = dt;
            con.Close();
        }
        private void catDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.catDGV.Rows[e.RowIndex];
                CatIdTb.Text = row.Cells["ID"].Value.ToString();
                CatNameTb.Text = row.Cells["Name"].Value.ToString();
                CatDescTb.Text = row.Cells["Description"].Value.ToString();
            }
        }
        void delete()
        {
            if (CatIdTb.Text != "" && CatNameTb.Text != "" && CatDescTb.Text != "")
            {
                con.Open();
                string query = "delete from Product_Category where ID='" + CatIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("successfully deleted!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
            }
            else MessageBox.Show("Please enter values! The fields are empty!!");
            populate();
            clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void update_Data()
        {
            if (CatNameTb.Text != "" && CatDescTb.Text != "")
            {
                con.Open();
                string query = "update Product_Category set Name = '" + CatNameTb.Text + "', Description = '" + CatDescTb.Text + "' where ID = "+CatIdTb.Text+"";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("Update operation is successfull.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
            }
            else MessageBox.Show("Please enter values! The fields are empty!!");
            populate();
            clear();
            CatIdTb.Text = "";
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            update_Data();
        }
    }
}
