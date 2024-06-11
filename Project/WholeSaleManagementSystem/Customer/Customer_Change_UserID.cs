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
    public partial class Customer_Change_UserID : Form
    {
        string customerID = "";
        Customer_Profile customer_Profile = null;
        SqlConnection con = Database_Connection.con;
        public Customer_Change_UserID(string customerID="", Customer_Profile customer_Profile=null)
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
        private void changeUserID()
        {
            con.Open();
            string query = "update customer set ID=@ID where ID=@customerID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", userid_textbox.Text);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    customerID = userid_textbox.Text;
                    MessageBox.Show("User ID is changed Successfully");
                    customer_Profile.customerID = customerID;
                    customer_Profile.loadform(new Customer_View_Profile(customerID));
                }
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }
        private void Customer_Change_UserID_Load(object sender, EventArgs e)
        {
            ID_label.Text = customerID;
        }

        bool validateUserID()
        {
            if (userid_textbox.Text == "")
            {
                useridErr.Text = "Please choose an user ID";
                return false;
            }
            else if(userid_textbox.Text == ID_label.Text)
            {
                useridErr.Text = "Your entered the old user ID!";
                return false;
            }
            else if (Regex.IsMatch(userid_textbox.Text, "^[a-zA-Z0-9]*$"))
            {
                con.Open();
                string query = "select * from Customer where id='" + userid_textbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                con.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    useridErr.Text = "This user ID  alredy exists";
                    return false;
                }
                else
                {
                    useridErr.Text = "";
                    return true;
                }
            }
            else
            {
                useridErr.Text = "Please enter a valid user id";
                return false;
            }
        }
        private void userid_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (validateUserID())
                {
                    e.Handled = true;
                    changeIDButton.PerformClick();
                }
            }
        }

        private void changeIDButton_Click(object sender, EventArgs e)
        {
            bool changeID_OK = true;
            if(!validateUserID())
            {
                changeID_OK = false;
            }
            if(changeID_OK)
            {
                changeUserID();
            }
        }
    }
}
