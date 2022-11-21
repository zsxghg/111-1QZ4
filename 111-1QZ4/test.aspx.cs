using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_conns = "Data Source=(localdb)\\ProjectModels;" +
                            "Initial Catalog=test;Integrated Security=True;" +
                            "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                            "User ID = sa; Password=12345";
            try
            {
                SqlConnection o_conns = new SqlConnection(s_conns);
                o_conns.Open();
                Response.Write("success");
                o_conns.Close();
            }
            catch (Exception o_exc)
            {

                Response.Write(o_exc.ToString());
            }
        }
    }
}