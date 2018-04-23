using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ImageColumn {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.DataSource = GetDateTable();
        }
        protected void Page_Load(object sender, EventArgs e) {
            ASPxGridView1.DataBind();
        }
        private object GetDateTable() {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Value", typeof(string));
            table.Rows.Add(1, "attach");
            table.Rows.Add(2, "n/a");
            table.Rows.Add(3, null);
            table.Rows.Add(4, "back");
            return table;
        }


        protected string GetImageName(object dataValue) {
            string val = string.Empty;
            try {
                val = (string)dataValue;
            }
            catch { }

            switch(val) {
                case "attach":
                    return "~/Images/attach32x32.png";
                case "back":
                    return "~/Images/back32x32.png";
                default:
                    return "~/Images/1x1.gif";
            }
        }

    }
}
