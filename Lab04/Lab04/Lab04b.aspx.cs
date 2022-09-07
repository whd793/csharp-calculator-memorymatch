using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Lab04
{
    public partial class Lab04b : System.Web.UI.Page
    {

        public String connStr = "Data Source=ecnmssqldev.ecn.purdue.edu;Initial Catalog=zCGT456_lee2530;Integrated Security=True";
        public String SQL;
        public SqlConnection oConn;
        public SqlCommand oCmd;
        public SqlDataReader sdr;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //nothing in here
        }


        private void ExecNonQuery(String sqlPassedIn)
        {
            oConn = new SqlConnection(connStr);
            oCmd = new SqlCommand(sqlPassedIn, oConn);
            oCmd.Connection.Open();
            oCmd.ExecuteNonQuery();
            oCmd.Connection.Close();
        }

        protected void select_Click(object sender, EventArgs e)
        {
            SQL = "SELECT * FROM Products_Lab4";
            oConn = new SqlConnection(connStr); //create connection to database to DB using string above
            oConn.Open();
            oCmd = new SqlCommand(SQL, oConn);
            sdr = oCmd.ExecuteReader();
            myDataGrid.DataSource = sdr;
            myDataGrid.DataBind();
            oConn.Close();
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            String title = "Intro to C#";
            String authors = "Whoever, Somebody A.";
            SQL = "INSERT INTO Products_Lab4(title, authors, copyrightDate, edition, isbn, coverart, description, price)";
            SQL += "VALUES('" + title + "', '" + authors + "', '060220', '4th', '123456789', 'computer image', 'intro to asp.net', '200.00')";
            ExecNonQuery(SQL);
            select_Click(sender, e);

        }

        protected void update_Click(object sender, EventArgs e)
        {
            SQL = "UPDATE Products_Lab4 SET Title='C# is FUN' WHERE ProductID=(SELECT MAX(ProductID) AS maxID FROM Products_Lab4)";
            ExecNonQuery(SQL);
            select_Click(sender, e);
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            SQL = "DELETE FROM Products_Lab4 WHERE ProductID=(SELECT MAX(ProductID) AS maxID FROM Products_Lab4)";
            ExecNonQuery(SQL);
            select_Click(sender, e);
        }
    }
}