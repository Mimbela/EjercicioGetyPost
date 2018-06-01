using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioGetyPost
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string dato = Request.Form["TextBox1"].ToString();
            Console.WriteLine(dato);

            int category = Convert.ToInt32(Request.Form["DropDownList1"]);
            Console.WriteLine(category);

            int supplier = Convert.ToInt32(Request.Form["DropDownList3"]);
            Console.WriteLine(supplier);

            int datoUnit = Convert.ToInt32 (Request.Form["TextBox2"]);
            Console.WriteLine(datoUnit);
            

        }
    }
}