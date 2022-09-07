using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calc1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void StoreDisplay(string fromDisplay)
    {
        Session["secondNumberClicked"] = fromDisplay.ToString();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        display.Text = "";
        Session["operation"] = "";
        Session["firstNumberClicked"] = "";
        Session["secondNumberClicked"] = "";

       
    }

    protected void BtnClicked(object sender, EventArgs e)
    {
        System.Web.UI.WebControls.Button myBtn;
        myBtn = (System.Web.UI.WebControls.Button)sender;

        display.Text = myBtn.Text.ToString();
        StoreDisplay(myBtn.Text.ToString());
    }
    

    protected void OperationClicked(object sender, EventArgs e)
    {


        Session["firstNumberClicked"] = Session["secondNumberClicked"];
        System.Web.UI.WebControls.Button myBtn;
        myBtn = (System.Web.UI.WebControls.Button)sender;
        Session["operation"] = myBtn.Text.ToString();
    }

  

    protected void BtnEqual_Click(object sender, EventArgs e)
    {
    

        if (Session["operation"] == "+") 
            display.Text = (Convert.ToInt32(Session["firstNumberClicked"].ToString()) + Convert.ToInt32(Session["secondNumberClicked"].ToString())).ToString();
        else if (Session["operation"] == "-")
            display.Text = (Convert.ToInt32(Session["firstNumberClicked"].ToString()) - Convert.ToInt32(Session["secondNumberClicked"].ToString())).ToString();
        else if (Session["operation"] == "*")
            display.Text = (Convert.ToInt32(Session["firstNumberClicked"].ToString()) * Convert.ToInt32(Session["secondNumberClicked"].ToString())).ToString();
        else if (Session["operation"] == "/")
            display.Text = (Convert.ToInt32(Session["firstNumberClicked"].ToString()) / Convert.ToInt32(Session["secondNumberClicked"].ToString())).ToString();
        
    }
    }
