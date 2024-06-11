using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WholeSaleManagementSystem
{
    public partial class ManageCustomer : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public ManageCustomer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            populate();
            cbSelectColumn.SelectedIndex = 0;
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            this.Hide();
            a1.Show();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if(WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1SL8C9\\SQLEXPRESS;Initial Catalog=WholeSaleManagementStudio;Integrated Security=True");
        private void insert_Data()
        {
            if (txtBoxFirstName.Text != "" && txtBoxLastName.Text != "" && txtBoxPhnNo.Text != "" && txtBoxEmail.Text != "" && txtBoxPass.Text != "")
            {
                con.Open();
                string query = "insert into Customer(ID, FirstName, LastName, PhoneNumber, Email, DOB, Password) values('" + txtBoxId.Text + "', '" + txtBoxFirstName.Text + "', '" + txtBoxLastName.Text + "', '" + txtBoxPhnNo.Text + "', '" + txtBoxEmail.Text + "', '" + dtpDOB.Value.ToString() + "', '" + txtBoxPass.Text + "')";
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
            clear();
            populate();
        }
        void clear()
        {
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxEmail.Text = "";
            txtBoxPhnNo.Text = "";
            dtpDOB.Value = DateTime.Now;
            txtBoxPass.Text = "";
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            custDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        //--------------------user id-------------------
        bool validateUserID()
        {
            if (txtBoxId.Text == "")
            {
                useridErr.Text = "Please choose an user ID";
                return false;
            }
            else if (Regex.IsMatch(txtBoxId.Text, "^[a-zA-Z0-9]*$"))
            {
                con.Open();
                string query = "select * from Customer where id='" + txtBoxId.Text + "'";
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
        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {
            validateUserID();
        }
        //---------------------email-----------------
        bool validateEmail()
        {
            if (txtBoxEmail.Text == "")
            {
                emailErr.Text = "Please Enter Your Email";
                return false;
            }
            else if (txtBoxEmail.Text.Contains("@") && txtBoxEmail.Text.Contains("."))
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
        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            validateEmail();
        }
        //----------------validate phone no
        bool validatePhone()
        {
            if (txtBoxPhnNo.Text == "")
            {
                phoneErr.Text = "Please Enter Your Phone";
                return false;
            }
            else
            {
                if (Regex.IsMatch(txtBoxPhnNo.Text, "^[0-9]*$"))
                {
                    if (txtBoxPhnNo.Text.Length == 11)
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
        private void txtBoxPhnNo_TextChanged(object sender, EventArgs e)
        {
            validatePhone();
        }
        //-----------------------dob--------------------------
        bool validateDOB()
        {
            if (dtpDOB.Checked)
            {
                if (DateTime.Compare(dtpDOB.Value, DateTime.Now.AddYears(-10)) <= 0)
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
        private void dtpDOB_CloseUp(object sender, EventArgs e)
        {
            validateDOB();
        }
        //------------password-----------------------
        bool validatePassword()
        {
            if (txtBoxPass.Text == "")
            {
                passwordErr.Text = "Please choose a password";
                return false;
            }
            else if (txtBoxPass.Text.Length < 8)
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
        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {
            validatePassword();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            bool insertOK = true;
            if (!validateEmail())
            {
                insertOK = false;
            }
            if (!validatePhone())
            {
                insertOK = false;
            }
            if (!validateUserID())
            {
                insertOK = false;
            }
            if (!validateDOB())
            {
                insertOK = false;
            }
            if (!validatePassword())
            {
                insertOK = false;
            }
            if (insertOK)
            {
                insert_Data();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string searchData = textBoxSearch.Text;
            string query = "select * from Customer ";
            if (cbSelectColumn.SelectedIndex == 0)
            {
                query += "where FirstName like '%" + searchData + "%' or LastName like '%" + searchData + "%' or PhoneNumber like '%" + searchData + "%'or Email like '%" + searchData + "%' or Password like '%" + searchData + "%'";
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
                    query += "where FirstName like '%" + searchData + "%'";
                }
                else if (cbSelectColumn.SelectedIndex == 3)
                {
                    query += "where LastName like '%" + searchData + "%'";
                }
                else if (cbSelectColumn.SelectedIndex == 4)
                {
                    query += "where PhoneNumber like '%" + searchData + "%'";
                }
                else if (cbSelectColumn.SelectedIndex == 5)
                {
                    query += "where Email like '%" + searchData + "%'";
                }
                else if (cbSelectColumn.SelectedIndex == 6)
                {
                    query += "where Password like '%" + searchData + "%'";
                }
            }

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable("Sellers");
            sda.Fill(dt);
            custDGV.DataSource = dt;
            con.Close();
        }

        private void custDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.custDGV.Rows[e.RowIndex];
                txtBoxId.Text = row.Cells["ID"].Value.ToString();
                txtBoxFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtBoxLastName.Text = row.Cells["LastName"].Value.ToString();
                txtBoxPhnNo.Text = row.Cells["PhoneNumber"].Value.ToString();
                dtpDOB.Text = row.Cells["DOB"].Value.ToString();
                txtBoxPass.Text = row.Cells["Password"].Value.ToString();
                txtBoxEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }
        private void delete()
        {
            if (txtBoxFirstName.Text != "" && txtBoxLastName.Text != "" && txtBoxPhnNo.Text != "" && txtBoxEmail.Text != "" && txtBoxPass.Text != "")
            {
                con.Open();
                string query = "delete from Customer where ID='" + txtBoxId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0) MessageBox.Show("successfully deleted.");
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
            }
            else MessageBox.Show("Please enter values! The fields are empty!!");
            clear();
            populate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void update_Data()
        {
            if (txtBoxFirstName.Text != "" && txtBoxLastName.Text != "" && txtBoxPhnNo.Text != "" && txtBoxEmail.Text != "" && txtBoxPass.Text != "")
            {
                con.Open();
                string query = "update Customer set ID = '" + txtBoxId.Text + "', FirstName = '" + txtBoxFirstName.Text + "', LastName = '" + txtBoxLastName.Text + "', PhoneNumber = '" + txtBoxPhnNo.Text + "', Email = '" + txtBoxEmail.Text + "', DOB = '" + dtpDOB.Value.ToString() + "', Password = '" + txtBoxPass.Text + "' where ID='" + txtBoxId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0) MessageBox.Show("Update is successfull.");
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
            }
            else MessageBox.Show("Please enter values! The fields are empty!!");
            clear();
            txtBoxId.Text = "";
            populate();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            update_Data();
        }
    }
}
