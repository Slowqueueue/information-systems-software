using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data;
using Npgsql;

namespace WebApplication_lr3
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string firstName = first_name.Text;
            string middleName = middle_name.Text;
            string lastName = last_name.Text;
            string number = phone.Text;
            string addr = address.Text;

            string sql =
                "INSERT INTO directory (lastname, firstname, patronymic, phone_number, address) VALUES"
                + $"('{lastName}', '{firstName}', '{middleName}', '{number}', '{addr}');";
            Database.Execute(sql);
            Response.Redirect("/");
        }
    }
}
