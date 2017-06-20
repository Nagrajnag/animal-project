using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imcs_assignment4
{
    public partial class gridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Samir Panigrahi\Documents\Visual Studio 2015\Projects\IMCS ASSIGNMENTS\demo.txt"))
            {
                string[] data = File.ReadAllLines(@"C:\Users\Samir Panigrahi\Documents\Visual Studio 2015\Projects\IMCS ASSIGNMENTS\demo.txt");

                DataTable dt = new DataTable();

                string[] col = data[0].Split(',');

                foreach (string s in col)
                {
                    dt.Columns.Add(s, typeof(string));
                }

                for (int i = 0; i < data.Length; i++)
                {
                    string[] row = data[i].Split(',');
                    dt.Rows.Add(row);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}