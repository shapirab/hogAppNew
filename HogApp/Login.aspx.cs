using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HogApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool isFaculty = FacultyDB.FacultyLogin(txtBoxUserName.Text, txtBoxPassword.Text);
            if(isFaculty==true)
            {
                Session["userName"] = txtBoxUserName.Text;
                Response.Redirect("FacultyScreen.aspx");
            }
            else
            {
                lbError.Visible = true;
            }
        }
    }
}