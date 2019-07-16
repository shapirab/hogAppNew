using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HogApp
{
    public partial class FacultyScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                StudentsDB.setFullNames();
            }

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int studentID = -99;
            studentID = Convert.ToInt32(Session["studentID"]);
            if (studentID != -99)
            {
                Student student = StudentsDB.getStudent(studentID);
                Logics logics = new Logics();
                int studentTotalPoints = logics.addPointsToStudent(student);
                Response.Write("Student total points: " + studentTotalPoints);
            }
            else
            {
                Response.Write("Please select a student");
            }

        }
        protected void btnSub_Click(object sender, EventArgs e)
        {
            int studentID = -99;
            studentID = Convert.ToInt32(Session["studentID"]);
            if (studentID != -99)
            {
                Student student = StudentsDB.getStudent(studentID);
                Logics logics = new Logics();
                int studentTotalPoints = logics.subtractPointsFromStudent(student);
                Response.Write("Student total points: " + studentTotalPoints);
            }
            else
            {
                Response.Write("Please select a student");
            }

        }
        protected void studentLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Session["studentID"] = Convert.ToInt32(lb.SelectedValue);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
        protected void fillListFromPartials(string partialName)
        {
            List<Student> matchingStudents = StudentsDB.getMatchingStudents(partialName);
            lbFullNamesByPartial.DataSource = matchingStudents;
            lbFullNamesByPartial.DataTextField = "fullName";
            lbFullNamesByPartial.DataValueField = "studentID";
            lbFullNamesByPartial.DataBind();
        }

        protected void btnGetStudFromPar_Click(object sender, EventArgs e)
        {
            string partialName = txtPartialName.Text;
            fillListFromPartials(partialName);
        }
    }
}
