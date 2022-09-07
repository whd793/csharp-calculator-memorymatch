using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Lab05
{
    public partial class Params : System.Web.UI.Page
    {

        private DbConn myDbConnection;
        private String SQL;
        private SqlDataReader myReader;
        private DataSet myDataSet;
        private DataTable myDataTable;
        private SqlConnection oConn;
        private SqlCommand oCmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            //nothing in here
        }

        protected void selectAll_Click(object sender, EventArgs e)
        {
            myDbConnection = new DbConn();
            SQL = "SELECT * FROM Products_Lab5";
            myReader = myDbConnection.createDataReader(SQL);
            myDataGrid.DataSource = myReader;
            myDataGrid.DataBind();

        }

        protected void selectOne_Click(object sender, EventArgs e)
        {
            myDbConnection = new DbConn();
            SQL = "SELECT Max(ProductID) As MaxID FROM Products_Lab5";
            myDataSet = new DataSet();
            myDataSet = myDbConnection.createDataSet(SQL);
            myDataTable = new DataTable();
            myDataTable = myDataSet.Tables[0];

            if(myDataTable.Rows[0][0].ToString() != "")
            {
                oConn = new SqlConnection(myDbConnection.connStr);
                oConn.Open();
                SQL = "SELECT * FROM Products_Lab5 WHERE ProductID=@prodID";
                oCmd = new SqlCommand(SQL, oConn);

                oCmd.Parameters.Add(new SqlParameter("@prodID", System.Data.SqlDbType.Int, 4));
                oCmd.Parameters["@prodID"].Value = myDataTable.Rows[0][0].ToString();

                myDataGrid.DataSource = oCmd.ExecuteReader();
                myDataGrid.DataBind();
                oConn.Close();
            }
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            myDbConnection = new DbConn();
            SQL = "INSERT INTO Products_Lab5(title, authors, copyrightDate, edition, isbn, coverart, description, price) ";
            SQL += "VALUES(@title, @authors, @copyrightDate, @edition, @isbn, @coverart, @description, @price)";

            oConn = new SqlConnection(myDbConnection.connStr);
            oCmd = new SqlCommand(SQL, oConn);

            oCmd.Parameters.Add(new SqlParameter("@title", System.Data.SqlDbType.VarChar, 100));
            oCmd.Parameters.Add(new SqlParameter("@authors", System.Data.SqlDbType.VarChar, 100));
            oCmd.Parameters.Add(new SqlParameter("@copyrightDate", System.Data.SqlDbType.VarChar, 6));
            oCmd.Parameters.Add(new SqlParameter("@edition", System.Data.SqlDbType.VarChar, 6));
            oCmd.Parameters.Add(new SqlParameter("@isbn", System.Data.SqlDbType.VarChar, 25));
            oCmd.Parameters.Add(new SqlParameter("@coverart", System.Data.SqlDbType.VarChar, 100));
            oCmd.Parameters.Add(new SqlParameter("@description", System.Data.SqlDbType.VarChar, 100));
            oCmd.Parameters.Add(new SqlParameter("@price", System.Data.SqlDbType.VarChar, 100));

            oCmd.Parameters["@title"].Value = "MSFT Visual Studio .net";
            oCmd.Parameters["@authors"].Value = "Bob and Carol";
            oCmd.Parameters["@copyrightDate"].Value = "2020";
            oCmd.Parameters["@edition"].Value = "2020";
            oCmd.Parameters["@isbn"].Value = "6549876544";
            oCmd.Parameters["@coverart"].Value = "Joe";
            oCmd.Parameters["@description"].Value = "A book about .net stuff";
            oCmd.Parameters["@price"].Value = "$95.00";

            oConn.Open();
            oCmd.ExecuteNonQuery();
            oConn.Close();

            selectAll_Click(sender, e);
        }

        protected void update_Click(object sender, EventArgs e)
        {
            myDbConnection = new DbConn();
            SQL = "SELECT Max(ProductID) As MaxID FROM Products_Lab5";
            myDataSet = new DataSet();
            myDataSet = myDbConnection.createDataSet(SQL);
            myDataTable = new DataTable();
            myDataTable = myDataSet.Tables[0];

            if (myDataTable.Rows[0][0].ToString() != "")
            {
                oConn = new SqlConnection(myDbConnection.connStr);
                SQL = "UPDATE Products_Lab5 SET Title=@title WHERE ProductID=@prodID";
                oCmd = new SqlCommand(SQL, oConn);

                oCmd.Parameters.Add(new SqlParameter("@prodID", System.Data.SqlDbType.Int, 4));

                oCmd.Parameters.Add(new SqlParameter("@title", System.Data.SqlDbType.VarChar, 100));
                oCmd.Parameters["@prodID"].Value = myDataTable.Rows[0][0].ToString();
                oCmd.Parameters["@title"].Value = "New title value";

                oConn.Open();
                oCmd.ExecuteNonQuery();
                oConn.Close();

                selectAll_Click(sender, e);
            }
          }

        protected void deleteOne_Click(object sender, EventArgs e)
        {
            myDbConnection = new DbConn();
            SQL = "SELECT Max(ProductID) As MaxID FROM Products_Lab5";
            myDataSet = new DataSet();
            myDataSet = myDbConnection.createDataSet(SQL);
            myDataTable = new DataTable();
            myDataTable = myDataSet.Tables[0];

            if (myDataTable.Rows[0][0].ToString() != "")
            {
                oConn = new SqlConnection(myDbConnection.connStr);
                SQL = "DELETE FROM Products_Lab5 WHERE ProductID=@prodID";
                oCmd = new SqlCommand(SQL, oConn);

                oCmd.Parameters.Add(new SqlParameter("@prodID", System.Data.SqlDbType.Int, 4));

            
                oCmd.Parameters["@prodID"].Value = myDataTable.Rows[0][0].ToString();

                oConn.Open();
                oCmd.ExecuteNonQuery();
                oConn.Close();

                selectAll_Click(sender, e);
            }
        }

        protected void deleteAll_Click(object sender, EventArgs e)
        {
            myDbConnection = new DbConn();
            SQL = "DELETE FROM Products_Lab5";
            oConn = new SqlConnection(myDbConnection.connStr);
            oCmd = new SqlCommand(SQL, oConn);

            oConn.Open();
            oCmd.ExecuteNonQuery();
            oConn.Close();

            selectAll_Click(sender, e);
        }

        protected void truncate_Click(object sender, EventArgs e)
        {
            myDbConnection = new DbConn();
            SQL = "TRUNCATE TABLE Products_Lab5";
            oConn = new SqlConnection(myDbConnection.connStr);
            oCmd = new SqlCommand(SQL, oConn);

            oConn.Open();
            oCmd.ExecuteNonQuery();
            oConn.Close();

            selectAll_Click(sender, e);
        }
    }
}