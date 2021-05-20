using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Threading;

public partial class _Default : System.Web.UI.Page
{
    public static String CS = ConfigurationManager.ConnectionStrings["MyShoppingDB"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["UserLogin"] == "YES")
        {
            Response.Redirect("UserHome.aspx?UserLogin=YES");
        }

        if (Session["Username"] != null)
        {            
            //lblSuccess.Text = "Login Success, Welcome <b>" + Session["Username"].ToString() + "</b>";
            
            if(!this.IsPostBack)
            {
                
            }

        }
        else
        {
           
           
            
            
        }

    }
  

    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session["Username"] = null;
        Session.RemoveAll();
        Response.Redirect("Default.aspx");
     }

    

    protected override void InitializeCulture()
    {
        CultureInfo ci = new CultureInfo("en-IN");
        ci.NumberFormat.CurrencySymbol = "";
        Thread.CurrentThread.CurrentCulture = ci;

        base.InitializeCulture();
    }
}