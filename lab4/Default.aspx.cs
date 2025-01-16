using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data;
using Npgsql;

namespace WebApplication_lr4
{
    public partial class _Default : System.Web.UI.Page
    {
        DataTable directory;
        string xmlPath = "C:\\Users\\nikit\\source\\repos\\WebApplication_lr4\\WebApplication_lr4\\xml_folder\\directory.xml";

        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "directory";
            string sql = $"SELECT id_record, lastname, firstname, patronymic, phone_number, address FROM {name};";
            directory = Database.Request(sql);
            directory.TableName = name;

            int numrows = directory.Rows.Count;
            int numcols = directory.Columns.Count;

            if (numrows != 0)
            {
                string[] headerPhrases = new string[] {
                    "Номер записи",
                    "ФИО",
                    "Телефон",
                    "Адрес",
                    "Действия"
                };
                TableHeaderRow header = new TableHeaderRow();
                for (int k = 0; k < headerPhrases.Length; k++)
                {
                    TableHeaderCell cell = new TableHeaderCell();
                    cell.Text = headerPhrases[k];
                    if (k == headerPhrases.Length - 1)
                    {
                        cell.CssClass = "text-center";
                        cell.Attributes["colspan"] = "2";
                    }
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
                        if (i == 1)
                        {
                            cell.Text = directory.Rows[j][i].ToString() +
                                ' ' + directory.Rows[j][i + 1].ToString() +
                                ' ' + directory.Rows[j][i + 2].ToString();
                            i += 2;
                        }
                        else
                        {
                            cell.Text = directory.Rows[j][i].ToString();
                        }
                        row.Cells.Add(cell);
                    }
                    cell = new TableCell();
                    cell.Text = $"<a href=\"./WebForm4.aspx?id_record={directory.Rows[j][0]}\">Изменить</a>";
                    row.Cells.Add(cell);
                    cell = new TableCell();
                    cell.Text = $"<a href=\"./WebForm3.aspx?id_record={directory.Rows[j][0]}\" style=\"color: #f00\">Удалить</a>";
                    row.Cells.Add(cell);
                    this.table.Rows.Add(row);
                }
            }
        }

        protected void saveXml_Click(object sender, EventArgs e)
        {
            directory.WriteXml(xmlPath);
        }

        protected void readXml_Click(object sender, EventArgs e)
        {
            directory.Clear();
            directory.ReadXml(xmlPath);
            int numrows = directory.Rows.Count;
            int numcols = directory.Columns.Count;

            string sql = "TRUNCATE directory; INSERT INTO directory VALUES ";

            for (int j = 0; j < numrows; j++)
            {
                sql += "(" + directory.Rows[j][0] + ',';

                for (int i = 1; i < numcols; i++)
                {
                    sql += "'" + directory.Rows[j][i].ToString() + "'";

                    if (i + 1 != numcols)
                    {
                        sql += ",";
                    }
                }

                sql += ")";

                if (j + 1 != numrows)
                {
                    sql += ",";
                }
            }
            sql += ";";

            Database.Execute(sql);
            Response.Redirect("/");
        }

        protected void clearMyTableBtn(object sender, EventArgs e)
        {
            Database.Execute("TRUNCATE directory;");
            Response.Redirect("/");
        }
    }
}
