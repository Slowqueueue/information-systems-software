using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                string expression = Request.Form["expr"];
                try
                {
                    double result = Convert.ToDouble(new DataTable().Compute(expression, null));
                    answer.Text = result.ToString();
                }
                catch (Exception err)
                {
                    answer.Text = "(Ошибка: " + err.Message + ')';
                }
            }
        }
    }
}
