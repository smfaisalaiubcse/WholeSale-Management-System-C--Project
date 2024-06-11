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
using WholeSaleManagementSystem.Seller;

namespace WholeSaleManagementSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "Exit Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void checkComboBox()
        {
            if (SelectRole.Text == "" || SelectRole.Text == "Select Role")
            {
                MessageBox.Show("Please select role first!!");
                SelectRole.Focus();
            }
            else if (SelectRole.Text != "Admin" && SelectRole.Text != "Seller" && SelectRole.Text != "Customer")
                MessageBox.Show("Don't type!\nTry to select the role from the drop down box!!");
        }
        public void verifyAdmin()
        {
            if (UserNameTxtBx.Text == "admin" && UserpassTxtBx.Text == "admin")
            {
                Admin a = new Admin();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!!!\nTry again.");
                UserNameTxtBx.Focus();
            }
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1SL8C9\\SQLEXPRESS;Initial Catalog=WholeSaleManagementStudio;Integrated Security=True");
        public void verifyCustomer()
        {
            con.Open();
            string query = "select * from Customer where id='" + UserNameTxtBx.Text + "' and password='" + UserpassTxtBx.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            con.Close();

            if (ds.Tables[0].Rows.Count == 1)
            {
                Customer a = new Customer(UserNameTxtBx.Text);
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!!!\nTry again.");
                UserNameTxtBx.Focus();
            }
        }

        public void verifySeller()
        {
            con.Open();
            string query = "select * from Seller where userID='" + UserNameTxtBx.Text + "' and password='" + UserpassTxtBx.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            con.Close();

            if (ds.Tables[0].Rows.Count == 1)
            {
                SellingForm sf = new SellingForm(UserNameTxtBx.Text);
                this.Hide();
                sf.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!!!\nTry again.");
                UserNameTxtBx.Focus();
            }
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            checkComboBox();
            if (SelectRole.Text == "Admin")
            {
                verifyAdmin();
            }
            else if(SelectRole.Text == "Seller")
            {
                verifySeller();
            }
            else if(SelectRole.Text == "Customer")
            {
                verifyCustomer();
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            UserNameTxtBx.Text = "";
            UserpassTxtBx.Text = "";
            UserNameTxtBx.Focus();
        }
        private void UserpassTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SelectRole.Text == "Admin")
                {
                    verifyAdmin();
                }
            }
        }

        private void UserNameTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserpassTxtBx.Focus();
            }
        }

        private void SelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectRole.SelectedIndex == 2)
            {
                Signup.Visible = true;
                Clear.Visible = false;
                Clear2.Visible = true;
            }
            else if(SelectRole.SelectedIndex == 0 || SelectRole.SelectedIndex == 1)
            {
                Signup.Visible = false;
                Clear2.Visible = false;
                Clear.Visible = true;
            }
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Customer_Signup cg = new Customer_Signup();
            this.Hide();
            cg.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
