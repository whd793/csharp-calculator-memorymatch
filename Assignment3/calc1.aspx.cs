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
        Session["displayedValue"] = fromDisplay.ToString();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        display.Text = "";
        Session["operation"] = "";
        Session["sum"] = "";
        Session["sub"] = "";
        Session["mult"] = "";
        Session["div"] = "";
        Session["displayedValue"] = "";
    }

    protected void Btn0_Click(object sender, EventArgs e)
    {
        display.Text = Btn0.Text.ToString();
        StoreDisplay(Btn0.Text.ToString());
    }

    protected void Btn1_Click(object sender, EventArgs e)
    {
        display.Text = Btn1.Text.ToString();
        StoreDisplay(Btn1.Text.ToString());
    }

    protected void Btn2_Click(object sender, EventArgs e)
    {
        display.Text = Btn2.Text.ToString();
        StoreDisplay(Btn2.Text.ToString());
    }

    protected void Btn3_Click(object sender, EventArgs e)
    {
        display.Text = Btn3.Text.ToString();
        StoreDisplay(Btn3.Text.ToString());
    }

    protected void Btn4_Click(object sender, EventArgs e)
    {
        display.Text = Btn4.Text.ToString();
        StoreDisplay(Btn4.Text.ToString());
    }

    protected void Btn5_Click(object sender, EventArgs e)
    {
        display.Text = Btn5.Text.ToString();
        StoreDisplay(Btn5.Text.ToString());
    }

    protected void Btn6_Click(object sender, EventArgs e)
    {
        display.Text = Btn6.Text.ToString();
        StoreDisplay(Btn6.Text.ToString());
    }

    protected void Btn7_Click(object sender, EventArgs e)
    {
        display.Text = Btn7.Text.ToString();
        StoreDisplay(Btn7.Text.ToString());
    }

    protected void Btn8_Click(object sender, EventArgs e)
    {
        display.Text = Btn8.Text.ToString();
        StoreDisplay(Btn8.Text.ToString());
    }

    protected void Btn9_Click(object sender, EventArgs e)
    {
        display.Text = Btn9.Text.ToString();
        StoreDisplay(Btn9.Text.ToString());
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["sum"] = Session["displayedValue"];
        Session["operation"] = "add";
    }

    protected void BtnSubtract_Click(object sender, EventArgs e)
    {
        Session["sub"] = Session["displayedValue"];
        Session["operation"] = "subtract";
    }

    protected void BtnMult_Click(object sender, EventArgs e)
    {
        Session["mult"] = Session["displayedValue"];
        Session["operation"] = "multiply";
    }

    protected void BtnDiv_Click(object sender, EventArgs e)
    {
        Session["div"] = Session["displayedValue"];
        Session["operation"] = "divide";
    }

    protected void BtnEqual_Click(object sender, EventArgs e)
    {
    

        if (Session["operation"] == "add") 
            display.Text = (Convert.ToInt32(Session["sum"].ToString()) + Convert.ToInt32(Session["displayedValue"].ToString())).ToString();
        else if (Session["operation"] == "subtract")
            display.Text = (Convert.ToInt32(Session["sub"].ToString()) - Convert.ToInt32(Session["displayedValue"].ToString())).ToString();
        else if (Session["operation"] == "multiply")
            display.Text = (Convert.ToInt32(Session["mult"].ToString()) * Convert.ToInt32(Session["displayedValue"].ToString())).ToString();
        else if (Session["operation"] == "divide")
            display.Text = (Convert.ToInt32(Session["div"].ToString()) / Convert.ToInt32(Session["displayedValue"].ToString())).ToString();
        
    }
    }
