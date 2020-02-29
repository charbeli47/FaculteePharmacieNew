using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class add_official_statement : System.Web.UI.Page
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
                    var res = dc.CMSGetOfficialStatementByID(id).Single();
                    hasfile.Checked = res.pdf != null && res.pdf != "";
                    title.Text = res.title;
                    desc.Text = res.description;
                    status.SelectedValue = res.status.ToString();
                    fileView.HRef = "~/Media/" + res.pdf;
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
                var res = dc.CMSGetOfficialStatementByID(id).Single();
                string fn = "";
                if (file.HasFile && Request["hasfile"] == "on")
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);
                    fn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        file.SaveAs(Server.MapPath("~/Media/" + fn));
                }
                else
                    fn = res.pdf;
                
                dc.UpdateOfficialStatement(id, fn, Request.Form["title"], Request.Form["desc"], int.Parse(Request["status"]), res.date_in);
            }
            else
            {
                string fn = "";
                if (file.HasFile && Request["hasfile"] == "on")
                {
                    var ext =System.IO.Path.GetExtension(file.FileName);
                    fn = Guid.NewGuid().ToString() + ext;
                    if(ext != ".exe" && ext!=".aspx" && ext!="php" && ext !="asp")
                        file.SaveAs(Server.MapPath("~/Media/"+fn));
                }

                dc.AddOfficialStatement(fn, Request.Form["title"], Request.Form["desc"], int.Parse(Request["status"]), DateTime.Now);
            }
            Response.Redirect("official-statement.aspx");
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
                Response.Redirect("official-statement.aspx", false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}