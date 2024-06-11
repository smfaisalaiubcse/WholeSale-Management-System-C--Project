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
    public partial class OrderList : Form
    {
        string customerID = "";
        public OrderList(string customerID = "")
        {
            InitializeComponent();
            this.customerID = customerID;
        }
        SqlConnection con = Database_Connection.con;
        private void populate()
        {
            con.Open();
            string query = "select ol.order_id, ol.product_id, pr.ProName, pr.ProPrice, ol.order_quantity, pr.ProCategory from order_list ol, Product pr where ol.product_id = pr.ProID and customer_id = '"+customerID+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            orderListDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void OrderList_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
