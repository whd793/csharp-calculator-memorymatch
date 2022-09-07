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
    public partial class Lab04a : System.Web.UI.Page
    {
        public String connStr = "Data Source=ecnmssqldev.ecn.purdue.edu;Initial Catalog=zCGT456_lee2530;Integrated Security=True";
        public String SQL;
        public SqlConnection oConn;
        public SqlCommand oCmd;



        protected void Page_Load(object sender, EventArgs e)
        {
            SQL = "SELECT DISTINCT title FROM EmployeesLab4";
            oConn = new SqlConnection(connStr);
            oConn.Open();
            oCmd = new SqlCommand(SQL, oConn);
            myList.DataSource = oCmd.ExecuteReader();
            myList.DataBind();
            oConn.Close();

            oConn.Open();
            SQL = "SELECT CONCAT(FirstName, ' ', Lastname) AS FLnames FROM EmployeesLab4";
            oCmd = new SqlCommand(SQL, oConn);
            names.DataSource = oCmd.ExecuteReader();
            names.DataBind();
            oConn.Close();

            oConn.Open();
            SQL = "SELECT HomePhone FROM EmployeesLab4";
            oCmd = new SqlCommand(SQL, oConn);
            phones.DataSource = oCmd.ExecuteReader();
            phones.DataBind();
            oConn.Close();

            oConn.Open();
            SQL = "SELECT City FROM EmployeesLab4";
            oCmd = new SqlCommand(SQL, oConn);
            cities.DataSource = oCmd.ExecuteReader();
            cities.DataBind();
            oConn.Close();
        }
    }
}