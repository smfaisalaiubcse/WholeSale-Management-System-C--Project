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
    public partial class ViewProduct : Form
    {
        string customerID = "";
        public ViewProduct()
        {
            InitializeComponent();
        }
        public ViewProduct(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        SqlConnection con = Database_Connection.con;
        public void populate()
        {
            con.Open();
            string currentDate = DateTime.Now.ToShortDateString();
            string search=searchBoxTextBox.Text;
            search = "%" + search + "%";
            string query = "select * from Product where expire_date>=@currentDate " +
                            "and ProQuantity>0" +
                            "and( upper(ProID) like upper(@search)" +
                            "or upper(ProName) like upper(@search)" +
                            "or upper(ProPrice) like upper(@search)" +
                            "or upper(ProQuantity) like upper(@search)" +
                            "or upper(ProCategory) like upper(@search) )";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@currentDate", currentDate);
            cmd.Parameters.AddWithValue("@search", search);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            sda.Fill(ds);
            //ProductDGV.DataSource = ds.Tables[0];
            con.Close();
            PrintRows(ds);
        }
        private void GoBack_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
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
        private void ViewProduct_Load(object sender, EventArgs e)
        {
            populate();
            panel1.AutoScroll = true;
        }
        private void PrintRows(DataSet dataSet)
        {
            panel1.Controls.Clear();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                individualProduct ip= new individualProduct(row, customerID, this);
                ip.Dock = DockStyle.Top;
                panel1.Controls.Add(ip);
            }
        }

        private void searchBoxTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            populate();
        }
    }
}
