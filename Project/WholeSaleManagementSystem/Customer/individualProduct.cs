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
    public partial class individualProduct : UserControl
    {
        string customerID="";
        DataRow row;
        ViewProduct viewProduct = null;


        public void popular()
        {
            proID_label.Text = row["ProID"].ToString();
            proName_label.Text = row["ProName"].ToString();
            proPrice_label.Text = row["ProPrice"].ToString();
            proQuantity_label.Text = row["ProQuantity"].ToString();
            proCategory_label.Text = row["ProCategory"].ToString();
        }
        public individualProduct(DataRow row=null, string customerID="", ViewProduct viewProduct = null)
        {
            InitializeComponent();
            proID_label.Text = row["ProID"].ToString();
            proName_label.Text = row["ProName"].ToString();
            proPrice_label.Text = row["ProPrice"].ToString();
            proQuantity_label.Text = row["ProQuantity"].ToString();
            proCategory_label.Text = row["ProCategory"].ToString();
            DateTime dateTime1 = Convert.ToDateTime(row["expire_date"].ToString());
            proExpireLabel.Text = dateTime1.ToShortDateString();
            this.customerID = customerID;
            this.viewProduct = viewProduct;
        }
        SqlConnection con = Database_Connection.con;
        void decrease_product_quantity()
        {
            con.Open();
            string query = "update product set proQuantity=@quantity where proID=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@quantity", Int32.Parse(proQuantity_label.Text)-quantity_updown.Value);
            cmd.Parameters.AddWithValue("@id", proID_label.Text);
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    //MessageBox.Show("Successfully Done");
                }
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }
        private void insert_Data()
        {
            con.Open();
            string query = "insert  into order_list (product_id, customer_id, order_quantity) values(@product_id, @customer_id, @order_quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", proID_label.Text);
            cmd.Parameters.AddWithValue("@customer_id", customerID);
            cmd.Parameters.AddWithValue("@order_quantity", quantity_updown.Value);
            if (con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0) MessageBox.Show("Ordered successfully.");
                //popular();
            }
            else
            {
                MessageBox.Show("Error, problem in con opening!!");
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(quantity_updown.Value <=Int32.Parse( proQuantity_label.Text))
            {
                insert_Data();
                decrease_product_quantity();
                this.viewProduct.populate();
            }
            else
            {
                MessageBox.Show("Sorry! Insufficient products available.");
            }
        }
    }
}
