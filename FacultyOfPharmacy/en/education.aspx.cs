using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.en
{
    public partial class education : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            var result = dc.CMSGetEducation().ToArray().OrderBy(x => x.sort).ToArray();

            var specialities = dc.CMSGetSpeciality().ToList();
            searchDropDown.Items.Clear();
            for (int i = 0; i < specialities.Count; i++)
            {
                var semesters = dc.CMSGetSemestersBySpecialityID(specialities[i].id).ToList();
                for (int j = 0; j < semesters.Count; j++)
                {
                    searchDropDown.Items.Add(new ListItem(specialities[i].frname + " - " + semesters[j].frname, semesters[j].id.ToString()));
                }
                result = result.Where(x => x.semesterId == semesters[0].id).ToArray();
                grid.DataSource = result;
                grid.DataBind();
            }
            searchDropDown.SelectedValue = Request["ctl00$ctl00$ContentPlaceHolder1$main$searchDropDown"];
        }

        protected void grid_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            int semesterId = int.Parse(Request["ctl00$ctl00$ContentPlaceHolder1$main$searchDropDown"]);
            var result = dc.CMSGetEducationBySemesterID(semesterId).ToArray().OrderBy(x => x.sort).ToArray();
            grid.DataSource = result;
            grid.PageIndex = e.NewPageIndex;
            grid.DataBind();
        }
        protected void searchDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            descriTitle.Visible = false;
            descriDesc.Visible = false;
            dcDataContext dc = new dcDataContext();
            int semesterId = int.Parse(Request["ctl00$ctl00$ContentPlaceHolder1$main$searchDropDown"]);
            var result = dc.CMSGetEducationBySemesterID(semesterId).ToArray().OrderBy(x => x.sort).ToArray();
            grid.DataSource = result;
            grid.DataBind();
        }
    }
}