using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Sample
{
    public partial class assignment5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string firstName = TextBox1.Text;
            Session["FirstName"] = firstName;
            string lastname = TextBox2.Text;
            Session["LastName"] = lastname;
            string department = DropDownList1.Text ;
            Session["Department"] = department;
            string email = TextBox4.Text;
            Session["Email"] = email;
            string password = TextBox6.Text;
            Session["Password"] = password;
            Response.Redirect("~/Sample/assignment6.aspx");
        }
    }
}