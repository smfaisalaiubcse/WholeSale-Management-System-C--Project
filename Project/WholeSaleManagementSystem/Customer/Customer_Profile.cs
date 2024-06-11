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
    public partial class Customer_Profile : Form
    {
        public string customerID="";
        public Customer_Profile(string customerID="")
        {
            InitializeComponent();
            this.customerID = customerID;
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
        SqlConnection con = Database_Connection.con;
        private void Customer_Profile_Load(object sender, EventArgs e)
        {
            loadform(new Customer_View_Profile(customerID));
        }
        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            loadform(new Customer_View_Profile(customerID));
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            loadform(new Customer_Edit_Profile(customerID, this));
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            loadform(new Customer_Change_Password(customerID, this));
        }

        private void changeIDButton_Click(object sender, EventArgs e)
        {
            loadform(new Customer_Change_UserID(customerID, this));
        }
    }
}
