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
    public partial class Customer_Change_Password : Form
    {
        string customerID = "";
        Customer_Profile customer_Profile = null;
        SqlConnection con = Database_Connection.con;
        public Customer_Change_Password(string customerID="", Customer_Profile customer_Profile = null)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.customer_Profile = customer_Profile;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "Exit Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void changePassword()
        {
            con.Open();
            string query = "update customer set password=@password where ID=@customerID and password=@oldPassword";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@password", password_textbox.Text);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Parameters.AddWithValue("@oldPassword", oldPasswordTextBox.Text);
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Password is changed Successfully");
                    customer_Profile.loadform(new Customer_View_Profile(customerID));
                }
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }

        private void Customer_Change_Password_Load(object sender, EventArgs e)
        {
            ID_label.Text = customerID;
        }

        bool validateOldPassword()
        {
            if (oldPasswordTextBox.Text == "")
            {
                oldPasswordErr.Text = "Please enter old password";
                return false;
            }
            else
            {
                //passwordErr.Text = "";
                //return true;
                con.Open();
                string query = "select * from customer where ID=@customerID and password=@oldPassword";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@oldPassword", oldPasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@customerID", customerID);
                
                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if(dataTable.Rows.Count == 1)
                    {
                        oldPasswordErr.Text = "";
                        con.Close();
                        return true;
                    }
                    else
                    {
                        oldPasswordErr.Text = "Please enter the correct old password";
                        con.Close();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                    con.Close();
                    return false;
                }
            }
        }
        private void oldPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (validateOldPassword())
                {
                    e.Handled = true;
                    password_textbox.Focus();
                }
            }
        }
        bool validatePassword()
        {
            if (password_textbox.Text == "")
            {
                passwordErr.Text = "Please choose a password";
                return false;
            }
            else if (password_textbox.Text.Length < 8)
            {
                passwordErr.Text = "Password must be at least 8 digits";
                return false;
            }
            else
            {
                passwordErr.Text = "";
                return true;
            }
        }
        private void password_textbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (validatePassword())
                {
                    e.Handled = true;
                    cpassword_textbox.Focus();
                }
            }
        }
        bool validateConfirmPassword()
        {
            if (cpassword_textbox.Text == "")
            {
                cpasswordErr.Text = "Please Confirm your password.";
                return false;
            }
            else if (cpassword_textbox.Text == password_textbox.Text)
            {
                cpasswordErr.Text = "";
                return true;
            }
            else
            {
                cpasswordErr.Text = "Password and confirm password must be same.";
                return false;
            }
        }
        private void cpassword_textbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (validateConfirmPassword())
                {
                    e.Handled = true;
                    changePasswordButton.PerformClick();
                }
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            bool passwordChangeOK = true;
            if (!validateOldPassword())
            {
                passwordChangeOK = false;
            }
            if (!validatePassword())
            {
                passwordChangeOK = false;
            }
            if (!validateConfirmPassword())
            {
                passwordChangeOK = false;
            }
            if (passwordChangeOK)
            {
                changePassword();
            }
        }
    }
}
