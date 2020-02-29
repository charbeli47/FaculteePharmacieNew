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
    public partial class add_news : System.Web.UI.Page
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
                    var res = dc.CMSGetNewsByID(id).Single();
                    entitle.Text = res.entitle;
                    artitle.Text = res.artitle;
                    entext.Text = res.entext;
                    artext.Text = res.artext;
                    frtext.Text = res.frtext;
                    this.haspdf.Checked = !string.IsNullOrEmpty(res.pdf);
                }
            }
        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            string str1 = this.Request.QueryString["action"];
            dcDataContext dcDataContext = new dcDataContext();
            if (str1 == "edit")
            {
                int num = int.Parse(this.Request.QueryString["id"]);
                CMSGetNewsByIDResult getNewsByIdResult = dcDataContext.CMSGetNewsByID(new int?(num)).Single<CMSGetNewsByIDResult>();
                string str2;
                if (this.pdf.HasFile && this.Request["haspdf"] == "on")
                {
                    string extension = Path.GetExtension(this.pdf.FileName);
                    str2 = Guid.NewGuid().ToString() + extension;
                    if (extension != ".exe" && extension != ".aspx" && extension != "php" && extension != "asp")
                        this.pdf.SaveAs(this.Server.MapPath("~/Media/" + str2));
                }
                else
                    str2 = getNewsByIdResult.pdf;
                dcDataContext.UpdateNews(new int?(num), this.Request.Form["artitle"], this.Request.Form["entitle"], this.Request.Form["frtitle"], this.Request.Form["artext"], this.Request.Form["entext"], this.Request.Form["frtext"], str2);
            }
            else
            {
                string str2 = "";
                if (this.pdf.HasFile && this.Request["haspdf"] == "on")
                {
                    string extension = Path.GetExtension(this.pdf.FileName);
                    str2 = Guid.NewGuid().ToString() + extension;
                    if (extension != ".exe" && extension != ".aspx" && extension != "php" && extension != "asp")
                        this.pdf.SaveAs(this.Server.MapPath("~/Media/" + str2));
                }
                dcDataContext.AddNews(this.Request.Form["artitle"], this.Request.Form["entitle"], this.Request.Form["frtitle"], this.Request.Form["artext"], this.Request.Form["entext"], this.Request.Form["frtext"], new DateTime?(DateTime.Now), str2);
            }
            this.Response.Redirect("news.aspx");
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
                Response.Redirect("news.aspx", false);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}