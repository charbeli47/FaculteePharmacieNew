using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                try
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
                catch
                {
                    msg.Text = "Incorrect username/password<div class='sep'></div><br/>";
                }
            }
        }
    }
}