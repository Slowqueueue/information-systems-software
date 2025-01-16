using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_lr3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.Params["id_record"];
            if (id == null) Response.Redirect("/");
            string sql = $"SELECT * FROM directory WHERE id_record = {id};";
            DataTable table = Database.Request(sql);

            int numrows = table.Rows.Count;
            if (numrows != 0)
            {
                last_name.Attributes["value"] = table.Rows[0][1].ToString();
                first_name.Attributes["value"] = table.Rows[0][2].ToString();
                middle_name.Attributes["value"] = table.Rows[0][3].ToString();
                phone.Attributes["value"] = table.Rows[0][4].ToString();
                address.Attributes["value"] = table.Rows[0][5].ToString();
            }
            else
            {
                Response.Redirect("/");
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string firstName = first_name.Text;
            string middleName = middle_name.Text;
            string lastName = last_name.Text;
            string number = phone.Text;
            string addr = address.Text;

            string sql = $"UPDATE directory SET lastname = '{lastName}', firstname = '{firstName}', patronymic = '{middleName}', phone_number = '{number}', address = '{addr}' WHERE id_record = {id};";
            Database.Execute(sql);
            Response.Redirect("/");
        }
    }
}
