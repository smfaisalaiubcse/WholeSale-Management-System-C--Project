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
    public partial class Customer_Signup : Form
    {

        SqlConnection con = Database_Connection.con;
        public Customer_Signup()
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
        
        private void Clear_Click(object sender, EventArgs e)
        {
            firstName_textbox.Text = "";
            password_textbox.Text = "";
            firstName_textbox.Focus();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Customer_Signup customer_Signup = new Customer_Signup();
            this.Hide();
            customer_Signup.ShowDialog();
        }
        //First name------------------------------------------------------------------------------------------------ First Name
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
            if (e.KeyCode == Keys.Enter)
            {
                if (validateFirstName())
                {
                    e.Handled = true;
                    lastName_textBox.Focus();
                }
            }
        }
        //Last name------------------------------------------------------------------------------------------------ Last Name
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

        //Email------------------------------------------------------------------------------------------------ Email
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

        //Phone------------------------------------------------------------------------------------------------ Phone
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
                userid_textbox.Focus();
            }
        }
        private void dobDatePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (validateDOB())
                {
                    e.Handled = true;
                    userid_textbox.Focus();
                }
            }
        }

        //Useri ID------------------------------------------------------------------------------------------------ User ID
        bool validateUserID()
        {
            if(userid_textbox.Text =="")
            {
                useridErr.Text = "Please choose an user ID";
                return false;
            }
            else if (Regex.IsMatch(userid_textbox.Text, "^[a-zA-Z0-9]*$"))
            {
                con.Open();
                string query = "select * from Customer where id='" + userid_textbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
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
            else if (password_textbox.Text.Length<8)
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
                    SignUpButton.PerformClick();
                }
            }
        }

        private void SignUpButton_Click_1(object sender, EventArgs e)
        {

            bool signupOk = true;
            if (!validateFirstName())
            {
                signupOk = false;
            }
            if (!validateLastName())
            {
                signupOk = false;
            }
            if (!validateEmail())
            {
                signupOk = false;
            }
            if (!validatePhone())
            {
                signupOk = false;
            }
            if (!validateUserID())
            {
                signupOk = false;
            }
            if (!validateDOB())
            {
                signupOk = false;
            }
            if (!validatePassword())
            {
                signupOk = false;
            }
            if (!validateConfirmPassword())
            {
                signupOk = false;
            }
            if (signupOk)
            {
                signup();
            }

        }
        private void signup()
        {
            con.Open();
            string query = "insert into customer(FirstName, LastName, email, phoneNumber, DOB, ID, password) " +
                                            "values(@firstName, @lastName, @email, @phoneNumber, @dob, @id, @password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@firstName", firstName_textbox.Text);
            cmd.Parameters.AddWithValue("@lastName", lastName_textBox.Text);
            cmd.Parameters.AddWithValue("@email", email_textbox.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", phone_textbox.Text);
            cmd.Parameters.AddWithValue("@dob", dobDatePicker.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@id", userid_textbox.Text);
            cmd.Parameters.AddWithValue("@password", password_textbox.Text);
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Successfully Signup");
                    LogIn logIn = new LogIn();
                    this.Hide();
                    logIn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }
        private void goto_login_Button_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }
        private void Clear_Click_1(object sender, EventArgs e)
        {
            firstName_textbox.Text = "";
            firstNameErr.Text = "";
            lastName_textBox.Text = "";
            lastNameErr.Text = "";
            email_textbox.Text = "";
            emailErr.Text = "";
            phone_textbox.Text = "";
            phoneErr.Text = "";
            dobDatePicker.Value = DateTime.Now;
            dobDatePicker.Checked = false;
            dobErr.Text = "";
            userid_textbox.Text = "";
            useridErr.Text = "";
            password_textbox.Text = "";
            passwordErr.Text = "";
            cpassword_textbox.Text = "";
            cpasswordErr.Text = "";
        }






        //private bool checkIdPass()
        //{
        //    if()
        //}
    }
}
