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
    public partial class ManageSeller : Form
    {
        public ManageSeller()
        {
            InitializeComponent();
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
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1SL8C9\\SQLEXPRESS;Initial Catalog=WholeSaleManagementStudio;Integrated Security=True");
        //private void insert_Data()
        //{
        //    if (txtBoxId.Text != "" || txtBoxName.Text != "" || textBoxPhoneNo.Text != "" || textBoxSalary.Text != "" || dtpDOB.Text != "" || textBoxPassword.Text != "")
        //    {
        //        con.Open();
        //        string query = "insert into Product_Category values('" + CatIdTb.Text + "', '" + CatNameTb.Text + "', '" + CatDescTb.Text + "')";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        if (con.State == ConnectionState.Open)
        //        {
        //            try
        //            {
        //                int result = cmd.ExecuteNonQuery();
        //                if (result > 0) MessageBox.Show("Insertion is successfull.");
        //            }
        //            catch (SqlException ex)
        //            {
        //                //string str;
        //                //str = "Source:" + ex.Source;
        //                //str += "\n" + "Number:" + ex.Number.ToString();
        //                //str = "\n" + "Message:" + ex.Message;
        //                //str += "\n" + "Class:" + ex.Class.ToString();
        //                //str += "\n" + "Procedure:" + ex.Procedure.ToString();
        //                //str += "\n" + "Line Number:" + ex.LineNumber.ToString();
        //                //str += "\n" + "Server:" + ex.Server.ToString();
        //                MessageBox.Show("Error! You can not add duplicate value of ID column!", "Error Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error, problem in con opening!!");
        //        }
        //        con.Close();
        //    }
        //    else MessageBox.Show("Please enter values! The fields are empty!!");
        //    populate();
        //}
        void generating_userid()
        {
            con.Open();
            string query = "update Seller set userID = concat('seller', id)";
            SqlCommand cmd = new SqlCommand(query, con);
            if (con.State == ConnectionState.Open)
            {
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0) MessageBox.Show("Auto userid generated");
                    query = "update Seller set userID = concat('seller', id)";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }
        bool validatePhone()
        {
            if (textBoxPhoneNo.Text == "")
            {
                phoneNumberErr.Text = "Please Enter Your Phone";
                return false;
            }
            else
            {
                if (Regex.IsMatch(textBoxPhoneNo.Text, "^[0-9]*$"))
                {
                    if (textBoxPhoneNo.Text.Length == 11)
                    {
                        phoneNumberErr.Text = "";
                        return true;
                    }
                    else 
                    {
                        phoneNumberErr.Text = "Phone must be exactly 11 digits";
                        return false;
                    }
                }
                else
                {
                    phoneNumberErr.Text = "Please enter a valid phone";
                    return false;
                }

            }
        }
        bool validatePassword()
        {
            if (textBoxPassword.Text == "")
            {
                passwordErr.Text = "Please enter password";
                return false;
            }
            else if (textBoxPassword.Text.Length < 8)
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
                    dobErr.Text = "Sellers age must be at least 10 years.";
                    return false;
                }
            }
            else
            {
                dobErr.Text = "Please enter sellers Birth of Date";
                return false;
            }
        }
        void insert()
        {
            if (txtBoxName.Text == "" || textBoxPhoneNo.Text == "" || textBoxSalary.Text == "" || textBoxPassword.Text == "" || dtpDOB.Text == "")
                MessageBox.Show("Fields are empty!!\nPlease enter values.");
            else
            {
                con.Open();
                string query = "insert into Seller(name, phoneNo, salary, dob, password) values('" + txtBoxName.Text + "', '" + textBoxPhoneNo.Text + "', '" + textBoxSalary.Text + "', '" + dtpDOB.Value.ToString() + "', '" + textBoxPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("Insertion is successfull.");
                        query = "update Seller set userID = concat('seller', id)";
                    }
                    catch (SqlException ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Number:" + ex.Number.ToString();
                        str = "\n" + "Message:" + ex.Message;
                        str += "\n" + "Class:" + ex.Class.ToString();
                        str += "\n" + "Procedure:" + ex.Procedure.ToString();
                        str += "\n" + "Line Number:" + ex.LineNumber.ToString();
                        str += "\n" + "Server:" + ex.Server.ToString();
                        MessageBox.Show("Error! You can not add duplicate value of ID column!", "Error Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
                clear();
                generating_userid();
                populate();
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (validatePhone() && validatePassword() && validateDOB())
            {
                insert();
            }
            else if (validatePhone() == false && validatePassword() == true && validateDOB() == true)
            {
                MessageBox.Show("please type phone number again.");
                textBoxPhoneNo.Text = "";
            }
            else if (validatePhone() == true && validatePassword() == false && validateDOB() == true)
            {
                MessageBox.Show("please type password again.");
                textBoxPassword.Text = "";
            }
            else if (validatePhone() == true && validatePassword() == false && validateDOB() == false)
            {
                MessageBox.Show("Seller age must be greater than 10!!");
                textBoxPassword.Text = "";
            }
            else MessageBox.Show("error!");
        }
        void delete()
        {
            if (txtBoxName.Text == "" || textBoxPhoneNo.Text == "" || textBoxSalary.Text == "" || textBoxPassword.Text == "" || dtpDOB.Text == "")
                MessageBox.Show("Fields are empty!!\nPlease enter values.");
            else
            {
                con.Open();
                string query = "delete from Seller where id = '" + txtBoxId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("successfuly deleted!");
                    }
                    catch (SqlException ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Number:" + ex.Number.ToString();
                        str = "\n" + "Message:" + ex.Message;
                        str += "\n" + "Class:" + ex.Class.ToString();
                        str += "\n" + "Procedure:" + ex.Procedure.ToString();
                        str += "\n" + "Line Number:" + ex.LineNumber.ToString();
                        str += "\n" + "Server:" + ex.Server.ToString();
                        MessageBox.Show("Error! You can not add duplicate value of ID column!", "Error Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
                clear();
                txtBoxId.Text = "";
                populate();
            }
        }
        public void clear()
        {
            txtBoxName.Text = "";
            textBoxPhoneNo.Text = "";
            textBoxSalary.Text = "";
            textBoxPassword.Text = "";
            dtpDOB.Text = "";
            dtpDOB.Value = DateTime.Now;
        }
        
        private void populate()
        {
            con.Open();
            string query = "select * from Seller";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            DataTable dt = new DataTable("Sellers");
            sda.Fill(dt);
            dgvSellerList.DataSource = dt;
            con.Close();
        }
        private void ManageSeller_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wholeSaleManagementStudioDataSet3.Seller' table. You can move, or remove it, as needed.
            this.sellerTableAdapter.Fill(this.wholeSaleManagementStudioDataSet3.Seller);
            populate();
            cbSelectColumn.SelectedIndex = 0;
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string searchData = textBoxSearch.Text;
            string query = "select * from Seller ";
            if(cbSelectColumn.SelectedIndex == 0)
            {
                query += "where name like '%" + searchData + "%' or phoneNo like '%" + searchData + "%' or password like '%" + searchData + "%'";
                if (int.TryParse(searchData, out _))
                    query += "or id = " + searchData;
            }
            else
            {
                if (cbSelectColumn.SelectedIndex == 1 && searchData.Length > 0)
                {
                    if (int.TryParse(searchData, out _))
                        query += "where id = "+searchData;
                }
                else if(cbSelectColumn.SelectedIndex == 2)
                {
                    query += "where name like '%"+searchData+"%'";
                }
                else if (cbSelectColumn.SelectedIndex == 3)
                {
                    query += "where phoneNo like '%"+searchData+"%'";
                }
            }  
            
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            DataTable dt = new DataTable("Sellers");
            sda.Fill(dt);
            dgvSellerList.DataSource = dt;
            con.Close();
        }

        private void dgvSellerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSellerList.Rows[e.RowIndex];
                txtBoxId.Text = row.Cells["id"].Value.ToString();
                txtBoxName.Text = row.Cells["name"].Value.ToString();
                textBoxPhoneNo.Text = row.Cells["PhoneNo"].Value.ToString();
                textBoxSalary.Text = row.Cells["salary"].Value.ToString();
                dtpDOB.Text = row.Cells["dob"].Value.ToString();
                textBoxPassword.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            delete();
        }

        void update()
        {
            if (txtBoxId.Text!="" && txtBoxName.Text == "" || textBoxPhoneNo.Text == "" || textBoxSalary.Text == "" || textBoxPassword.Text == "" || dtpDOB.Text == "")
                MessageBox.Show("Fields are empty!!\nPlease enter values.");
            else
            {
                con.Open();
                string query = "update Seller set name = '" + txtBoxName.Text + "', phoneNo = '" + textBoxPhoneNo.Text + "', salary = '" + textBoxSalary.Text + "', dob = '" + dtpDOB.Value.ToString() + "', password = '" + textBoxPassword.Text + "' where id = '"+txtBoxId.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("Update operation is successfull.");
                    }
                    catch (SqlException ex)
                    {
                        string str;
                        str = "Source:" + ex.Source;
                        str += "\n" + "Number:" + ex.Number.ToString();
                        str = "\n" + "Message:" + ex.Message;
                        str += "\n" + "Class:" + ex.Class.ToString();
                        str += "\n" + "Procedure:" + ex.Procedure.ToString();
                        str += "\n" + "Line Number:" + ex.LineNumber.ToString();
                        str += "\n" + "Server:" + ex.Server.ToString();
                        MessageBox.Show("Error! You can not add duplicate value of ID column!", "Error Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, problem in con opening!!");
                }
                con.Close();
                clear();
                txtBoxId.Text = "";
                populate();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            update();
        }

        private void textBoxPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (validatePhone())
                {
                    e.Handled = true;
                    textBoxSalary.Focus();
                }
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (validatePassword())
                {
                    e.Handled = true;
                    textBoxPassword.Focus();
                }
            }
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            validatePassword();
        }
        private void dtpDOB_CloseUp(object sender, EventArgs e)
        {
            if (validateDOB())
            {
                textBoxPassword.Focus();
            }
        }

        private void txtBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                textBoxPhoneNo.Focus();
        }
    }
}
