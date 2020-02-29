using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class add_orientation_files : System.Web.UI.Page
    {
        protected int graduationId;
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
                int id = int.Parse(Request.QueryString["id"]);
                var res = dc.CMSGetOrientationFilesByID(id).Single();
                title.Text = res.title;
                frtitle.Text = res.frtitle;
            }
        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            dcDataContext dc = new dcDataContext();
            if (action == "edit")
            {
                int id = int.Parse(Request.QueryString["id"]);
                var res = dc.CMSGetOrientationFilesByID(id).Single();
                File.Delete(Server.MapPath("~/Media/"+res.filename));
                dc.DeleteOrientationFile(id);
                string fn = "";
                if (file.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);
                    fn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        file.SaveAs(Server.MapPath("~/Media/" + fn));
                }
                dc.CreateOrientationFile(fn, Request["title"], Request["frtitle"]);
            }
            else
            {
                string fn = "";
                if (file.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);
                    fn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        file.SaveAs(Server.MapPath("~/Media/" + fn));
                }
                dc.CreateOrientationFile(fn, Request["title"], Request["frtitle"]);
            }
            Response.Redirect("orientation-files.aspx");
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
                Response.Redirect("orientation-files.aspx", false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}