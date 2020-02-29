using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class add_graduation : System.Web.UI.Page
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
                int categoryId = int.Parse(Request["categoryId"]);
                string action = Request.QueryString["action"];

                if (action == "edit")
                {
                    int id = int.Parse(Request.QueryString["id"]);

                    var res = dc.CMSGetGraduationByID(id).Single();
                    enname.Text = res.enname;
                    frname.Text = res.frname;
                    arname.Text = res.arname;
                    entext.Text = res.entext;
                    frtext.Text = res.frtext;
                    artext.Text = res.artext;
                    smallentext.Text = res.ensmalltext;
                    smallfrtext.Text = res.frsmalltext;
                    smallartext.Text = res.arsmalltext;
                }
            }
        }
        protected void savebtn_Click(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            int categoryId = int.Parse(Request["categoryId"]);
            dcDataContext dc = new dcDataContext();
            if (action == "edit")
            {
                int id = int.Parse(Request.QueryString["id"]);
                dc.UpdateGraduation(id, Request.Form["arname"], Request.Form["enname"], Request.Form["frname"], Request.Form["artext"], Request.Form["entext"], Request.Form["frtext"], categoryId, Request.Form["smallartext"], Request.Form["smallentext"], Request.Form["smallfrtext"]);
            }
            else
            {
                dc.AddGraduation(Request.Form["arname"], Request.Form["enname"], Request.Form["frname"], Request.Form["artext"], Request.Form["entext"], Request.Form["frtext"], categoryId, Request.Form["smallartext"], Request.Form["smallentext"], Request.Form["smallfrtext"]);
            }
            Response.Redirect("graduation.aspx?categoryId="+categoryId);
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
                Response.Redirect("graduation.aspx?categoryId=" + Request["categoryId"], false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}