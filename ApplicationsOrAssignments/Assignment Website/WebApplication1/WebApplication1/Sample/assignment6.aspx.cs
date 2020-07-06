using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Sample
{
    public partial class assignment6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string firstName = (string)(Session["FirstName"]);
            string lastname = (string)(Session["LastName"]);
            string department = (string)(Session["Department"]);
            string email = (string)(Session["Email"]);
            string password = (string)(Session["Password"]);

            Label2.Text = firstName;
            if (!string.IsNullOrEmpty(Session["LastName"] as string))
            {
                Label4.Text = lastname;
            }
            else
            {
                Label4.Text = "No input given";
            }
            Label6.Text = department;
            Label8.Text = email;
            Label10.Text = password;

        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Sample/assignment5.aspx");
        }

    }
}