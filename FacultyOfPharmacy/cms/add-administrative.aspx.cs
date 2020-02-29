using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class add_administrative : System.Web.UI.Page
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

                string action = Request.QueryString["action"];
                if (action == "edit")
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    dcDataContext dc = new dcDataContext();
                    var res = dc.CMSGetAdministrativeByID(id).Single();
                    enname.Text = res.enname;
                    frname.Text = res.frname;
                    arname.Text = res.arname;
                    endesc.Text = res.endescription;
                    frdesc.Text = res.frdescription;
                    ardesc.Text = res.ardescription;
                    status.SelectedValue = res.status.ToString();
                    hasphoto.Checked = res.icon != null && res.icon != "";
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
                var res = dc.CMSGetAdministrativeByID(id).Single();
                string ifn = "";
                if (photo.HasFile && Request["hasphoto"] == "on")
                {
                    var ext = System.IO.Path.GetExtension(photo.FileName);
                    ifn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        photo.SaveAs(Server.MapPath("~/Media/" + ifn));
                }
                else
                    ifn = res.icon;
                dc.UpdateAdministratifs(id, Request.Form["arname"], Request.Form["enname"], Request.Form["frname"], Request.Form["ardesc"], Request.Form["endesc"], Request.Form["frdesc"], ifn, int.Parse(Request["status"]));
            }
            else
            {
                string ifn = "";
                if (photo.HasFile && Request["hasphoto"] == "on")
                {
                    var ext = System.IO.Path.GetExtension(photo.FileName);
                    ifn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        photo.SaveAs(Server.MapPath("~/Media/" + ifn));
                }
                dc.AddAdministratifs(Request.Form["arname"], Request.Form["enname"], Request.Form["frname"], Request.Form["ardesc"], Request.Form["endesc"], Request.Form["frdesc"], ifn, int.Parse(Request["status"]));
            }
            Response.Redirect("administrative.aspx");
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
                Response.Redirect("default.aspx", false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}