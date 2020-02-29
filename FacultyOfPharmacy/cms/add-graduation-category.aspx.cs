using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class add_graduation_category : System.Web.UI.Page
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
                
                string action = Request.QueryString["action"];

                if (action == "edit")
                {
                    int id = int.Parse(Request.QueryString["id"]);

                    var res = dc.CMSGetGraduationCategoriesByID(id).Single();
                    enname.Text = res.enname;
                    frname.Text = res.frname;
                    arname.Text = res.arname;
                }
            }
        }
        protected void savebtn_Click(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            dcDataContext dc = new dcDataContext();
            string fn = "";
            if (action == "edit")
            {
                int id = int.Parse(Request.QueryString["id"]);
                dc.UpdateGraduationCategory(id, Request.Form["arname"], Request.Form["enname"], Request.Form["frname"]);
            }
            else
            {
                dc.AddGraduationCategory(Request.Form["arname"], Request.Form["enname"], Request.Form["frname"]);
            }
            Response.Redirect("graduation-categories.aspx");
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
                Response.Redirect("graduation-categories.aspx", false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}