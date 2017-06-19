using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace imcs_assignment4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private object reader;
        private object lblmessage;
        private object confirm;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            Response.Write( "Page load event handled. <br />");

            if (Page.IsPostBack)
            {
              Response.Write("Page post back event handled.<br/>");
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write( "Page initialization event handled.<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write( "Page prerender event handled. <br/>");
        }
        protected void page_preinit(object sender, EventArgs e)
        {
            Response.Write("Page preinit event handled. <br/>");
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(@"C:\Users\Samir Panigrahi\Documents\Visual Studio 2015\Projects\demo.txt", true);
            txt.WriteLine(TextBox1.Text,"\n" );
            txt.WriteLine(TextBox2.Text, "\n");
            txt.WriteLine(TextBox3.Text, "\n");
            conform.Visible = true;
            txt.Close();
        }
    }
}