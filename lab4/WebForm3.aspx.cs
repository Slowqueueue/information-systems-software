using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Diagnostics;

namespace WebApplication_lr4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id_record"] != null)
            {
                Database.Execute($"DELETE FROM directory WHERE id_record = {Request.Params["id_record"]};");
                Response.Redirect("/");
            }
            string sql = "SELECT id_record, lastname, patronymic, firstname, phone_number FROM directory;";
            DataTable table = Database.Request(sql);

            int numrows = table.Rows.Count;
            int numcols = table.Columns.Count;

            if (numrows != 0)
            {
                for (int j = 0; j < numrows; j++)
                {
                    ListItem listItem = new ListItem(
                        table.Rows[j]["phone_number"].ToString() + " - " +
                        table.Rows[j]["firstname"].ToString() + " " +
                        table.Rows[j]["patronymic"].ToString() + " " +
                        table.Rows[j]["lastname"].ToString()
                        );
                    listItem.Value = table.Rows[j]["id_record"].ToString();
                    list.Items.Add(listItem);
                }
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM directory WHERE id_record = {list.SelectedValue};";
            Database.Execute(sql);

            Response.Redirect("/");
        }
    }
}
