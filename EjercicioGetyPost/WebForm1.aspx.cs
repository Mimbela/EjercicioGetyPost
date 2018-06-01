using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioGetyPost
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm2.aspx");
        }

        protected void btnSave2_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            int category = int.Parse(DropDownList1.SelectedValue);
            int supplier = int.Parse(DropDownList3.SelectedValue);
            int unitPrice = int.Parse(TextBox2.Text);
            Response.Redirect("WebForm3.aspx?TextBox1=" + name+ "&DropDownList1=" + category+ "&DropDownList3=" + supplier+ "&TextBox2=" + unitPrice);
        }
    }
}

    //get: paso por response redirect y recupero por reques query string

    //post: paso por server tranfer y recupero por request form--%>