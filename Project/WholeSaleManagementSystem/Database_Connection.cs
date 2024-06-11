using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WholeSaleManagementSystem
{
    internal class Database_Connection
    {
        public static SqlConnection  con
        {
            get { return new SqlConnection("Data Source=DESKTOP-A1SL8C9\\SQLEXPRESS;Initial Catalog=WholeSaleManagementStudio;Integrated Security=True"); }
        }
    }
}
