using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.MyDB
{
    class MyDBXe
    {
        //field
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DSXE; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        //property
        public SqlConnection GetSqlConnection {
            get { return this.sqlConnection; }
        }
        //methods
        public void OpenConnection()
        {
            sqlConnection.Open();
        }
        public void CloseConnection()
        {
            sqlConnection.Close();
        }

    }
}
