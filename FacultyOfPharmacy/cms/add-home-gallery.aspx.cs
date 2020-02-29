using Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.cms
{
    public partial class add_home_gallery : System.Web.UI.Page
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

                dcDataContext dc = new dcDataContext(); 
                if (action == "edit")
                {
                    
                    int id = int.Parse(Request.QueryString["id"]);
                    
                    var res = dc.CMSGetHomeGalleryByID(id).SingleOrDefault();
                    title.Text = res.title;
                    description.Text = res.description;
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
                var res = dc.CMSGetHomeGalleryByID(id).SingleOrDefault();
                string sfn = "";
                if (thumbnail.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(thumbnail.FileName);
                    sfn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        thumbnail.SaveAs(Server.MapPath("~/Media/" + sfn));
                }
                else
                    sfn = res.image;
                dc.UpdateHomeGallery(id, Request["title"], Request["description"],  sfn);
            }
            else
            {
                string sfn = "";
                if (thumbnail.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(thumbnail.FileName);
                    sfn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        thumbnail.SaveAs(Server.MapPath("~/Media/" + sfn));
                }
                dc.CreateHomeGallery(Request["title"], Request["description"], sfn);
            }
            Response.Redirect("home-gallery.aspx");
        }
        protected void loginButton_Click(object sender, EventArgs e)
        {
            Encryptor enc = new Encryptor();
            dcDataContext dc = new dcDataContext();
            int? b = dc.CMSLogin(Request["uname"], Encryptor.MD5Hash(Request["pass"]));
            if (b != -1)
            {
                Session.Add("User", b);
                Session.Add("Username", Request["uname"]);
                DateTime date = DateTime.Now;
                Session["DateLogin"] = date.ToString("dd-MM-yyyy hh:mm tt");
                dc.UpdateCMSUserLoginDate(date, b);
                var user = dc.GetCMSUsersByID(b).Single();
                Session["GroupID"] = user.groupId;
                Session.Timeout = 60;
                Response.Redirect("home-gallery.aspx");
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}