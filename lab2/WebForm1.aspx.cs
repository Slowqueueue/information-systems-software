using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_lr2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (first_name.Text != "" && last_name.Text != "" && email.Text != "" && password.Text != "" && password.Text == password_check.Text) 
                {
                Session["firstname"] = first_name.Text;
                Session["lastname"] = last_name.Text;
                Response.Redirect("WebForm2.aspx");
                }
                else
                {
                    if (first_name.Text == "") Response.Write("<h3 class=\"panel-title\"><center>Не введено имя</center></h3>");
                    if (last_name.Text == "") Response.Write("<h3 class=\"panel-title\"><center>Не введена фамилия</center></h3>");
                    if (email.Text == "") Response.Write("<h3 class=\"panel-title\"><center>Не введен Email</center></h3>");
                    if (password.Text != password_check.Text) Response.Write("<h3 class=\"panel-title\"><center>Пароли не совпадают</center></h3>");
                    if (password.Text == "" || password_check.Text == "") Response.Write("<h3 class=\"panel-title\"><center>Введите и подтвердите пароль</center></h3>");
                }
            }
        }
    }
}
