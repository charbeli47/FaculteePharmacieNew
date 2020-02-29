using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class add_education : System.Web.UI.Page
    {
        protected int semesterId;
        protected void Page_Load(object sender, EventArgs e)
        {
            semesterId = int.Parse(Request["semesterId"]);
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
                    
                    var res = dc.CMSGetEducationByID(id).Single();
                    title.Text = res.title;
                    total_hours.Text = res.total_hours;
                    theory.Text = res.theorie;
                    td.Text = res.td;
                    tp.Text = res.tp;
                    credits.Text = res.credits.ToString();
                    pre_req.Text = res.pre_req;
                    description.Text = res.description;
                    status.SelectedValue = res.status.ToString();
                    code.Text = res.code.ToString();
                }
            }
        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            dcDataContext dc = new dcDataContext();
            if (action == "edit")
            {
                int id = int.Parse(Request.QueryString["id"]);
                var res = dc.CMSGetEducationByID(id).Single();
                dc.UpdateEducation(id, Request.Form["title"], Request.Form["total_hours"], Request.Form["theory"], Request.Form["td"], Request.Form["tp"], decimal.Parse(Request.Form["credits"]), Request.Form["pre_req"], Request.Form["description"], Request.Form["code"], int.Parse(Request["status"]), semesterId);
            }
            else
            {
                dc.AddEducation(Request.Form["title"], Request.Form["total_hours"], Request.Form["theory"], Request.Form["td"], Request.Form["tp"], decimal.Parse(Request.Form["credits"]), Request.Form["pre_req"], Request.Form["description"], Request.Form["code"], int.Parse(Request["status"]), semesterId);
            }
            Response.Redirect("education.aspx?semesterId=" + semesterId);
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
                Response.Redirect("education.aspx?semesterId="+Request["semesterId"], false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}