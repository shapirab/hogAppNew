using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HogApp
{
    public partial class Results : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblChampion1.Text = "אלוף הבית" + " " + Logics.getCurrentHouseChampion(3);
            lblChampion2.Text = "אלוף הבית" + " " + Logics.getCurrentHouseChampion(4);
            lblChampion3.Text = "אלוף הבית" + " " + Logics.getCurrentHouseChampion(5);
            lblChampion4.Text = "אלוף הבית" + " " + Logics.getCurrentHouseChampion(6);

            lblHouse1.Text = HouseDB.getHouse(3).HouseName;
            lblHouse2.Text = HouseDB.getHouse(4).HouseName;
            lblHouse3.Text = HouseDB.getHouse(5).HouseName;
            lblHouse4.Text = HouseDB.getHouse(6).HouseName;

            lblTotalPointsHs1.Text = Convert.ToString(HouseDB.getHousePoints(3));
            lblTotalPointsHs2.Text = Convert.ToString(HouseDB.getHousePoints(4));
            lblTotalPointsHs3.Text = Convert.ToString(HouseDB.getHousePoints(5));
            lblTotalPointsHs4.Text = Convert.ToString(HouseDB.getHousePoints(6));

            lblSchoolChamp.Text = Logics.getCurrentSchoolChampion();

            Response.AppendHeader("Refresh", "2");
        }
    }
}