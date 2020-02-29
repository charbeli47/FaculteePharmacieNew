using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class add_semester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Loged.Visible = false;
                notLoged.Visible = true;
            }
            else
            {
                Loged.Visible = true;
                notLoged.Visible = false;
                dcDataContext dc = new dcDataContext();
                int specialityId = int.Parse(Request["specialityId"]);
                string action = Request.QueryString["action"];

                if (action == "edit")
                {
                    int id = int.Parse(Request.QueryString["id"]);

                    var res = dc.CMSGetSemestersByID(id).Single();
                    enname.Text = res.enname;
                    frname.Text = res.frname;
                    arname.Text = res.arname;
                }
            }
        }
        protected void savebtn_Click(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            int specialityId = int.Parse(Request["specialityId"]);
            dcDataContext dc = new dcDataContext();
            if (action == "edit")
            {
                int id = int.Parse(Request.QueryString["id"]);
                dc.UpdateSemester(id, Request.Form["enname"], Request.Form["arname"], Request.Form["frname"], specialityId);
            }
            else
            {
                dc.AddSemester(Request.Form["enname"], Request.Form["arname"], Request.Form["frname"], specialityId);
            }
            Response.Redirect("semesters.aspx?specialityId="+specialityId);
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            int? b = dc.CMSLogin(Request["uname"], Encryptor.MD5Hash(Request["pass"]));
            if (b == -2)
            {
                msg.Text = "Please activate your account!<div class='sep'></div><br/>";
            }
            else if (b != -1)
            {
                Session.Add("User", b);
                Session.Add("Username", Request["uname"]);
                DateTime date = DateTime.Now;
                Session["DateLogin"] = date.ToString("dd-MM-yyyy hh:mm tt");
                dc.UpdateCMSUserLoginDate(date, b);
                Session.Timeout = 60;
                var user = dc.GetCMSUsersByID(b).Single();
                Session["GroupID"] = user.groupId;
                Response.Redirect("semesters.aspx?specialityId=" + Request["specialityId"], false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}