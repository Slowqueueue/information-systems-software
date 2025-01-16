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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id_record, CONCAT(lastname, ' ', firstname, ' ', patronymic) AS FIO, phone_number, address FROM directory;";
            DataTable table = Database.Request(sql);

            int numrows = table.Rows.Count;
            int numcols = table.Columns.Count;

            if (numrows != 0)
            {
                string[] headerPhrases = new string[] {
                    "Номер записи",
                    "ФИО",
                    "Телефон",
                    "Адрес",
                    " ",
                    " "
                };
                TableHeaderRow header = new TableHeaderRow();
                for (int k = 0; k < headerPhrases.Length; k++)
                {
                    TableHeaderCell cell = new TableHeaderCell();
                    cell.Text = headerPhrases[k];
                    header.Cells.Add(cell);
                }
                this.table.Rows.Add(header);

                for (int j = 0; j < numrows; j++)
                {
                    TableRow row = new TableRow();
                    TableCell cell = new TableCell();
                    for (int i = 0; i < numcols; i++)
                    {
                        cell = new TableCell();
                        cell.Text = table.Rows[j][i].ToString();
                        row.Cells.Add(cell);
                    }
                    cell = new TableCell();
                    cell.Text = $"<a href=\"./WebForm4.aspx?id_record={table.Rows[j][0]}\">Изменить</a>";
                    row.Cells.Add(cell);
                    cell = new TableCell();
                    cell.Text = $"<a href=\"./WebForm3.aspx?id_record={table.Rows[j][0]}\" style=\"color: #f00\">Удалить</a>";
                    row.Cells.Add(cell);
                    this.table.Rows.Add(row);
                }
            }
        }
    }
}
