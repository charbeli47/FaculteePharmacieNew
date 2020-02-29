using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class add_research_teams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["User"] == null)
            {
                this.Loged.Visible = false;
                this.notLoged.Visible = true;
            }
            else
            {
                this.Loged.Visible = true;
                this.notLoged.Visible = false;
                if (this.Request.QueryString["action"] == "edit")
                {
                    CMSGetResearchTeamsByIdResult researchTeamsByIdResult = new dcDataContext().CMSGetResearchTeamsById(new int?(int.Parse(this.Request.QueryString["id"]))).Single<CMSGetResearchTeamsByIdResult>();
                    this.entitle.Text = researchTeamsByIdResult.entitle;
                    this.frtitle.Text = researchTeamsByIdResult.frtitle;
                    this.enmembersText.Text = researchTeamsByIdResult.enmembersText;
                    this.frmembersText.Text = researchTeamsByIdResult.frmembersText;
                    this.enpublicationsText.Text = researchTeamsByIdResult.enpublicationsText;
                    this.frpublicationsText.Text = researchTeamsByIdResult.frpublicationsText;
                }
            }
        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            string str = this.Request.QueryString["action"];
            dcDataContext dcDataContext = new dcDataContext();
            if (str == "edit")
            {
                int num = int.Parse(this.Request.QueryString["id"]);
                dcDataContext.CMSGetResearchTeamsById(new int?(num)).Single<CMSGetResearchTeamsByIdResult>();
                dcDataContext.UpdateResearchTeams(new int?(num), this.Request.Form["entitle"], this.Request.Form["frtitle"], this.Request.Form["enmembersText"], this.Request.Form["frmembersText"], this.Request.Form["enpublicationsText"], this.Request.Form["frpublicationsText"]);
            }
            else
                dcDataContext.AddResearchTeams(this.Request.Form["entitle"], this.Request.Form["frtitle"], this.Request.Form["enmembersText"], this.Request.Form["frmembersText"], this.Request.Form["enpublicationsText"], this.Request.Form["frpublicationsText"]);
            this.Response.Redirect("research-teams.aspx");
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            dcDataContext dcDataContext = new dcDataContext();
            int? nullable1 = dcDataContext.CMSLogin(this.Request["uname"], Encryptor.MD5Hash(this.Request["pass"]));
            int? nullable2 = nullable1;
            int num1 = -2;
            if (nullable2.GetValueOrDefault() == num1 && nullable2.HasValue)
            {
                this.msg.Text = "Please activate your account!<div class='sep'></div><br/>";
            }
            else
            {
                nullable2 = nullable1;
                int num2 = -1;
                if (nullable2.GetValueOrDefault() != num2 || !nullable2.HasValue)
                {
                    this.Session.Add("User", (object)nullable1);
                    this.Session.Add("Username", (object)this.Request["uname"]);
                    DateTime now = DateTime.Now;
                    this.Session["DateLogin"] = (object)now.ToString("dd-MM-yyyy hh:mm tt");
                    dcDataContext.UpdateCMSUserLoginDate(new DateTime?(now), nullable1);
                    this.Session.Timeout = 60;
                    this.Session["GroupID"] = (object)dcDataContext.GetCMSUsersByID(nullable1).Single<GetCMSUsersByIDResult>().groupId;
                    this.Response.Redirect("research-teams.aspx", false);
                }
                else
                    this.msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}