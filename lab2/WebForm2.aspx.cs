using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_lr2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstname"] == null || Session["lastname"] == null) Response.Redirect("/");
            hello.Text = "Привет, " + (string)Session["firstname"] + " " + (string)Session["lastname"] + "!";
        }
    }
}
