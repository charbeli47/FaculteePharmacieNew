using Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.cms
{
    public partial class add_gallery_images : System.Web.UI.Page
    {
        protected int categoryId;
        protected string action = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Loged.Visible = false;
                notLoged.Visible = true;
            }
            else
            {
                categoryId = int.Parse(Request["categoryId"]);
                Loged.Visible = true;
                notLoged.Visible = false;
                action = Request.QueryString["action"];
                dcDataContext dc = new dcDataContext();
                if (action == "edit")
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    var gallimgs = dc.CMSGetGalleryImagesByGalleryID(id).ToList();
                    for (int i = 0; i < gallimgs.Count; i++)
                    {
                        string imRes = "../Media/" + gallimgs[i].img;
                        Gallimages.Text += "<div id=\"" + gallimgs[i].id + "\" style=\"background-image:url(" + imRes + ");width:200px;height:200px;background-size:cover;float:left;margin-left:5px;margin-top:5px\"><div onclick='deleteImg(\"" + gallimgs[i].id + "\")' style='cursor:pointer;float:right;'><img src='img/i_delete.png'/></div></div>";
                    }
                    var res = dc.CMSGetGalleryByID(id).SingleOrDefault();
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
                var res = dc.CMSGetGalleryByID(id).SingleOrDefault();
                string sfn = "", pfn = "";
                if (smallImage.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(smallImage.FileName);
                    sfn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != ".php" && ext != ".asp")
                        smallImage.SaveAs(Server.MapPath("~/Media/" + sfn));
                }
                else
                    sfn = res.SmallImage;
                if (largeImage.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(largeImage.FileName);
                    pfn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != ".php" && ext != ".asp")
                        largeImage.SaveAs(Server.MapPath("~/Media/" + pfn));
                }
                else
                    pfn = res.LargeImage;
                dc.UpdateGallery(id, Request["title"], Request["description"],  sfn, pfn, categoryId);
            }
            else
            {
                string sfn = "", pfn = "";
                if (smallImage.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(smallImage.FileName);
                    sfn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        smallImage.SaveAs(Server.MapPath("~/Media/" + sfn));
                }
                if (largeImage.HasFile)
                {
                    var ext = System.IO.Path.GetExtension(largeImage.FileName);
                    pfn = Guid.NewGuid().ToString() + ext;
                    if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                        largeImage.SaveAs(Server.MapPath("~/Media/" + pfn));
                }
                dc.CreateGallery(Request["title"], Request["description"],sfn, pfn, categoryId);
            }
            Response.Redirect("gallery-images.aspx?categoryId="+Request["categoryId"]);
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
                Response.Redirect("gallery-images.aspx?categoryId=" + Request["categoryId"]);
            }
            else
            {
                msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
            }
        }
    }
}