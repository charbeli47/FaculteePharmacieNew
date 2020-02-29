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
    public partial class add_graduation_files : System.Web.UI.Page
    {
        protected int graduationId, id;
        protected void Page_Load(object sender, EventArgs e)
        {
            graduationId = int.Parse(Request["graduationId"]);
            if (Session["User"] == null)
            {
                Loged.Visible = false;
                notLoged.Visible = true;
            }
            else
            {
                string action = Request.QueryString["action"];
                Loged.Visible = true;
                notLoged.Visible = false;
                dcDataContext dc = new dcDataContext();
                if (action == "edit")
                {
                    var file = dc.CMSGetGraduationFilesById(id).SingleOrDefault();
                    title.Text = file.title;
                    frtitle.Text = file.frtitle;
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
                var res = dc.CMSGetGraduationFilesById(id).Single();
                File.Delete(Server.MapPath("~/Media/"+res.filename));
                dc.DeleteGraduationFile(id);
                string fn = "";
                if (file.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);
                    fn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        file.SaveAs(Server.MapPath("~/Media/" + fn));
                }
                dc.AddGraduationFile(fn, graduationId,Request["title"], Request["frtitle"]);
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
                dc.AddGraduationFile(fn, graduationId, Request["title"], Request["frtitle"]);
            }
            Response.Redirect("graduation-files.aspx?graduationId=" + graduationId);
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
                Response.Redirect("graduation-files.aspx?graduationId="+Request["graduationId"], false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}