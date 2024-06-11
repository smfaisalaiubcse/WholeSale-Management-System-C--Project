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
    public partial class Customer_Edit_Profile : Form
    {
        string customerID = "";
        Customer_Profile customer_Profile = null;
        SqlConnection con = Database_Connection.con;
        public Customer_Edit_Profile(string customerID="", Customer_Profile customer_Profile = null)
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
        bool validateFirstName()
        {
            if(firstName_textbox.Text =="")
            {
                firstNameErr.Text = "Please Enter Your User Name";
                return false;
            }
            else
            {
                firstNameErr.Text = "";
                return true;
            }
        }
        private void firstName_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    if(validateFirstName())
                    {
                        lastName_textBox.Focus();
                    }
                }
                
            }
        }
        bool validateLastName()
        {
            if (lastName_textBox.Text == "")
            {
                lastNameErr.Text = "Please Enter Your User Name";
                return false;
            }
            else
            {
                lastNameErr.Text = "";
                return true;
            }
        }

        private void lastName_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (validateLastName())
                {
                    e.Handled = true;
                    email_textbox.Focus();
                }
            }
        }
        bool validateEmail()
        {
            if (email_textbox.Text == "")
            {
                emailErr.Text = "Please Enter Your Email";
                return false;
            }
            else if (email_textbox.Text.Contains("@") && email_textbox.Text.Contains("."))
            {
                emailErr.Text = "";
                return true;
            }
            else
            {
                emailErr.Text = "Please enter an valid email";
                return false;
            }
        }
        private void email_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(validateEmail())
                {
                    e.Handled= true;
                    phone_textbox.Focus();
                }
            }
        }

        bool validatePhone()
        {
            if (phone_textbox.Text == "")
            {
                phoneErr.Text = "Please Enter Your Phone";
                return false;
            }
            else
            {
                if (Regex.IsMatch(phone_textbox.Text, "^[0-9]*$"))
                {
                    if(phone_textbox.Text.Length == 11)
                    {
                        phoneErr.Text = "";
                        return true;
                    }
                    else
                    {
                        phoneErr.Text = "Phone must be 11 digits";
                        return false;
                    }
                }
                else
                {
                    phoneErr.Text = "Please enter a valid phone";
                    return false;
                }
                
            }
        }
        private void phone_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (validatePhone())
                {
                    e.Handled = true;
                    dobDatePicker.Focus();
                }
            }
        }
        //DOB------------------------------------------------------------------------------------------------ DOB
        bool validateDOB()
        {
            if (dobDatePicker.Checked)
            {
                if (DateTime.Compare(dobDatePicker.Value, DateTime.Now.AddYears(-10)) <= 0)
                {
                    dobErr.Text = "";
                    return true;
                }
                else
                {
                    dobErr.Text = "Your age must be at least 10 years.";
                    return false;
                }
            }
            else
            {
                dobErr.Text = "Please enter your Birth of Date";
                return false;
            }
        }
        private void dobDatePicker_CloseUp(object sender, EventArgs e)
        {
            if (validateDOB())
            {
                EditButton.PerformClick();
            }
        }
        private void dobDatePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (validateDOB())
                {
                    e.Handled = true;
                    EditButton.PerformClick();
                }
            }
        }

        private void edit()
        {
            con.Open();
            string query = "update customer set firstName=@firstName, LastName=@lastName, phoneNumber=@phoneNumer, email=@email, DOB=@dob where ID=@customerID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@firstName", firstName_textbox.Text);
            cmd.Parameters.AddWithValue("@lastName", lastName_textBox.Text);
            cmd.Parameters.AddWithValue("@phoneNumer", phone_textbox.Text);
            cmd.Parameters.AddWithValue("@email", email_textbox.Text);
            cmd.Parameters.AddWithValue("@dob", dobDatePicker.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@customerID", customerID);
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Successfully edited");
                    customer_Profile.loadform(new Customer_View_Profile(customerID));
                }
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            bool editOK = true;
            if (!validateFirstName())
            {
                editOK = false;
            }
            if (!validateLastName())
            {
                editOK = false;
            }
            if (!validateEmail())
            {
                editOK = false;
            }
            if (!validatePhone())
            {
                editOK = false;
            }
            if (!validateDOB())
            {
                editOK = false;
            }
            if (editOK)
            {
                edit();
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
                firstName_textbox.Text= dt.Rows[0]["FirstName"].ToString();
                lastName_textBox.Text= dt.Rows[0]["LastName"].ToString();
                phone_textbox.Text= dt.Rows[0]["phoneNumber"].ToString();
                email_textbox.Text= dt.Rows[0]["email"].ToString();
                //dobDatePicker.Value=DateTime.Parse(dt.Rows[0]["DOB"].ToString());
                if(DateTime.TryParse(dt.Rows[0]["DOB"].ToString(),out DateTime dateTime))
                {
                    dobDatePicker.Value= dateTime;
                    dobDatePicker.Checked = true;
                }
                else
                {
                    dobDatePicker.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }
        private void Customer_Edit_Profile_Load(object sender, EventArgs e)
        {
            ID_label.Text = customerID;
            loadData();
        }
    }
}
