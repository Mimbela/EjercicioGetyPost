using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioGetyPost
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["TextBox1"];
            int supplier = Convert.ToInt32( Request.QueryString["DropDownList3"]);
            int category = Convert.ToInt32(Request.QueryString["DropDownList1"]);
            int unitPrice = Convert.ToInt32(Request.QueryString["TextBox2"]);
            Console.WriteLine("",name,supplier,category,unitPrice);


        }
    }
}