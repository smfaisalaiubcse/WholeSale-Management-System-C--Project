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
using System.Text.RegularExpressions;

namespace WholeSaleManagementSystem
{
    public partial class Customer_View_Profile : Form
    {
        string customerID = "";
        SqlConnection con = Database_Connection.con;
        public Customer_View_Profile(string customerID="")
        {
            InitializeComponent();
            this.customerID = customerID;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "Exit Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void loadData()
        {
            con.Open();
            string query = "select * from customer where ID=@customerID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            if (con.State == ConnectionState.Open)
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                firstNameLabel.Text= dt.Rows[0]["FirstName"].ToString();
                lastNameLabel.Text= dt.Rows[0]["LastName"].ToString();
                phoneLabel.Text= dt.Rows[0]["phoneNumber"].ToString();
                emailLabel.Text= dt.Rows[0]["email"].ToString();
                if(DateTime.TryParse(dt.Rows[0]["DOB"].ToString(), out DateTime dateTime))
                {
                    dobLabel.Text= dateTime.ToShortDateString();
                }
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }
        private void Customer_View_Profile_Load(object sender, EventArgs e)
        {
            ID_label.Text = customerID;
            loadData();
        }
    }
}
