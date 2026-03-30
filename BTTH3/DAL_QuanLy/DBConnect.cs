using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=513;Initial Catalog=QLSV;Integrated Security=True"); 
    }
}
