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

namespace WholeSaleManagementSystem.Seller
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        string sellerUserID;
        public SellingForm(string sellerUserID)
        {
            InitializeComponent();
            this.sellerUserID = sellerUserID;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1SL8C9\\SQLEXPRESS;Initial Catalog=WholeSaleManagementStudio;Integrated Security=True");
        private void populate()
        {
            con.Open();
            string query = "select proName,proPrice from Product where ProCategory ='"+cmbcategory.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            proSDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        
        private void populate_SelledProDGV()
        {
            con.Open();
            string query = "select * from SelledProductList";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SelledProDGV.DataSource = ds.Tables[0];
            con.Close();
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
                cmbcategory.Items.Add(row["name"].ToString());
            }
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'wholeSaleManagementStudioDataSet2.SellsList' table. You can move, or remove it, as needed.
            //this.sellsListTableAdapter.Fill(this.wholeSaleManagementStudioDataSet2.SellsList);
            //// TODO: This line of code loads data into the 'wholeSaleManagementStudioDataSet1.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.wholeSaleManagementStudioDataSet1.Product);
            //// TODO: This line of code loads data into the 'wholeSaleManagementStudioDataSet.SelledProductList' table. You can move, or remove it, as needed.
            //this.selledProductListTableAdapter.Fill(this.wholeSaleManagementStudioDataSet.SelledProductList);
            populate();
            populate_BillDGV();
            populate_SelledProDGV();
            load_catagory_comboBox();
        }

        private void proSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.proSDGV.Rows[e.RowIndex];
                proName.Text = row.Cells["proName"].Value.ToString();
                proPrice.Text = row.Cells["proPrice"].Value.ToString();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LogIn lgin = new LogIn();
            this.Hide();
            lgin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Date.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            
            Sellername.Text = sellerUserID;
        }
        private void insert_Data()
        {
            if (proQuant.Text != "")
            {
                con.Open();
                double totalPrice = Single.Parse(proPrice.Text) * Single.Parse(proQuant.Text);
                string query = "insert into SelledProductList (ProName, Quantity, Price) values('" + proName.Text + "', '" + proQuant.Text + "', "+totalPrice+")";
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
        private void AddPro_Click(object sender, EventArgs e)
        {
            insert_Data();
            populate_SelledProDGV();
            Tprice.Text = "0";
            for (int i = 0; i < SelledProDGV.Rows.Count; i++)
            {
                Tprice.Text = Convert.ToString(double.Parse(Tprice.Text) + double.Parse(SelledProDGV.Rows[i].Cells[3].Value.ToString()));
            }
        }
        private void populate_BillDGV()
        {
            con.Open();
            string query = "select * from BillTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            billDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Add_Bill_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into BillTable (SellerName, BillDate, TotalAmount) values('" + Sellername.Text + "', '" + Date.Text + "', '" + Tprice.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0) MessageBox.Show("Order added successfully.");
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
            populate_BillDGV();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select proName,proPrice from Product";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            proSDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Whole Sale Management Studio", new Font("Century Gothik", 25, FontStyle.Bold), Brushes.Red, new Point(185));
            Bitmap imagebmp = new Bitmap(billDGV.Width, billDGV.Height);
            billDGV.DrawToBitmap(imagebmp, new Rectangle(0, 0, billDGV.Width, billDGV.Height));
            e.Graphics.DrawImage(imagebmp, 120, 100);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
