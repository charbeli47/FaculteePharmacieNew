using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace FacultyOfPharmacy.cms
{
    public partial class settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/cms/config.config"));
            DataTable dt = new DataTable();
            dt = ds.Tables["Settings"];
            Description.Text = dt.Select("Name='Description'")[0]["Value"].ToString();
            Keywords.Text = dt.Select("Name='Keywords'")[0]["Value"].ToString();
            smtpServer.Text = dt.Select("Name='smtpServer'")[0]["Value"].ToString();
            smtpPort.Text = dt.Select("Name='smtpPort'")[0]["Value"].ToString();
            emailUser.Text = dt.Select("Name='emailUser'")[0]["Value"].ToString();
            emailPassword.Text = dt.Select("Name='emailPassword'")[0]["Value"].ToString();
            recipient.Text = dt.Select("Name='recipient'")[0]["Value"].ToString();
            senders.Text = dt.Select("Name='sender'")[0]["Value"].ToString();
            WebsiteLink.Text = dt.Select("Name='WebsiteLink'")[0]["Value"].ToString();
            enDeanWord.Text = dt.Select("Name='enDeanWord'")[0]["Value"].ToString();
            frDeanWord.Text = dt.Select("Name='frDeanWord'")[0]["Value"].ToString();
            arDeanWord.Text = dt.Select("Name='arDeanWord'")[0]["Value"].ToString();
            DeanImg.ImageUrl = "~/Media/DeanWord/"+dt.Select("Name='thumbDeanWord'")[0]["Value"].ToString();

            enHistory.Text = dt.Select("Name='enHistory'")[0]["Value"].ToString();
            frHistory.Text = dt.Select("Name='frHistory'")[0]["Value"].ToString();
            arHistory.Text = dt.Select("Name='arHistory'")[0]["Value"].ToString();
            HistoryImg.ImageUrl = "~/Media/History/" + dt.Select("Name='thumbHistory'")[0]["Value"].ToString();

            enOrganigrame.Text = dt.Select("Name='enOrganigrame'")[0]["Value"].ToString();
            frOrganigrame.Text = dt.Select("Name='frOrganigrame'")[0]["Value"].ToString();
            arOrganigrame.Text = dt.Select("Name='arOrganigrame'")[0]["Value"].ToString();
            OrganigrameImg.ImageUrl = "~/Media/Organigrame/" + dt.Select("Name='thumbOrganigrame'")[0]["Value"].ToString();

            enMission.Text = dt.Select("Name='enMission'")[0]["Value"].ToString();
            frMission.Text = dt.Select("Name='frMission'")[0]["Value"].ToString();
            arMission.Text = dt.Select("Name='arMission'")[0]["Value"].ToString();

            enAffairEstudiantine.Text = dt.Select("Name='enAffairEstudiantine'")[0]["Value"].ToString();
            frAffairEstudiantine.Text = dt.Select("Name='frAffairEstudiantine'")[0]["Value"].ToString();
            arAffairEstudiantine.Text = dt.Select("Name='arAffairEstudiantine'")[0]["Value"].ToString();

            enOrientation.Text = dt.Select("Name='enOrientation'")[0]["Value"].ToString();
            frOrientation.Text = dt.Select("Name='frOrientation'")[0]["Value"].ToString();
            arOrientation.Text = dt.Select("Name='arOrientation'")[0]["Value"].ToString();

            enHrOrganigrame.Text = dt.Select("Name='enHROrganigrame'")[0]["Value"].ToString();
            frHROrganigrame.Text = dt.Select("Name='frHROrganigrame'")[0]["Value"].ToString();
            arHROrganigrame.Text = dt.Select("Name='arHROrganigrame'")[0]["Value"].ToString();
            HROrganigrameImg.ImageUrl = "~/Media/HROrganigrame/" + dt.Select("Name='thumbHROrganigrame'")[0]["Value"].ToString();

            enConseil.Text = dt.Select("Name='enConseil'")[0]["Value"].ToString();
            frConseil.Text = dt.Select("Name='frConseil'")[0]["Value"].ToString();
            arConseil.Text = dt.Select("Name='arConseil'")[0]["Value"].ToString();

            enEmployment.Text = dt.Select("Name='enEmployment'")[0]["Value"].ToString();
            frEmployment.Text = dt.Select("Name='frEmployment'")[0]["Value"].ToString();
            arEmployment.Text = dt.Select("Name='arEmployment'")[0]["Value"].ToString();

            enAlumni.Text = dt.Select("Name='enAlumni'")[0]["Value"].ToString();
            frAlumni.Text = dt.Select("Name='frAlumni'")[0]["Value"].ToString();
            arAlumni.Text = dt.Select("Name='arAlumni'")[0]["Value"].ToString();
        }

        protected void saveSEO_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/cms/config.config"));
            DataTable dt = new DataTable();
            dt = ds.Tables["Settings"];
            dt.Select("Name='WebsiteLink'")[0]["Value"] = Request.Form["ctl00$main$WebsiteLink"];
            dt.Select("Name='Description'")[0]["Value"] = Request.Form["ctl00$main$Description"];
            dt.Select("Name='Keywords'")[0]["Value"] = Request.Form["ctl00$main$Keywords"];
            dt.Select("Name='smtpServer'")[0]["Value"] = Request.Form["ctl00$main$smtpServer"];
            dt.Select("Name='smtpPort'")[0]["Value"] = Request.Form["ctl00$main$smtpPort"];
            dt.Select("Name='emailUser'")[0]["Value"] = Request.Form["ctl00$main$emailUser"];
            dt.Select("Name='emailPassword'")[0]["Value"] = Request.Form["ctl00$main$emailPassword"];
            dt.Select("Name='recipient'")[0]["Value"] = Request.Form["ctl00$main$recipient"];
            dt.Select("Name='sender'")[0]["Value"] = Request.Form["ctl00$main$senders"];

            dt.Select("Name='enDeanWord'")[0]["Value"] = Request.Form["ctl00$main$enDeanWord"];
            dt.Select("Name='frDeanWord'")[0]["Value"] = Request.Form["ctl00$main$frDeanWord"];
            dt.Select("Name='arDeanWord'")[0]["Value"] = Request.Form["ctl00$main$arDeanWord"];
            string fnDeanWord = "";
            if (thumbDeanWord.HasFile)
            {
                var ext = System.IO.Path.GetExtension(thumbDeanWord.FileName);
                if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                {
                    fnDeanWord = Guid.NewGuid().ToString() + ext;
                    string path = Server.MapPath("~/Media/DeanWord");
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    try
                    {
                        File.Delete(path + "/" + dt.Select("Name='thumbDeanWord'")[0]["Value"]);
                    }
                    catch { }
                    thumbDeanWord.SaveAs(Server.MapPath("~/Media/DeanWord/" + fnDeanWord));
                }

            }
            else
            {
                fnDeanWord = dt.Select("Name='thumbDeanWord'")[0]["Value"].ToString();
            }
            dt.Select("Name='thumbDeanWord'")[0]["Value"] = fnDeanWord;
            dt.Select("Name='enHistory'")[0]["Value"] = Request.Form["ctl00$main$enHistory"];
            dt.Select("Name='frHistory'")[0]["Value"] = Request.Form["ctl00$main$frHistory"];
            dt.Select("Name='arHistory'")[0]["Value"] = Request.Form["ctl00$main$arHistory"];
            string fnHistory = "";
            if (thumbHistory.HasFile)
            {
                var ext = System.IO.Path.GetExtension(thumbHistory.FileName);
                if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                {
                    fnHistory = Guid.NewGuid().ToString() + ext;
                    string path = Server.MapPath("~/Media/History");
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    try
                    {
                        File.Delete(path + "/" + dt.Select("Name='thumbHistory'")[0]["Value"]);
                    }
                    catch { }
                    thumbHistory.SaveAs(Server.MapPath("~/Media/History/" + fnHistory));
                }

            }
            else
            {
                fnHistory = dt.Select("Name='thumbHistory'")[0]["Value"].ToString();
            }
            dt.Select("Name='thumbHistory'")[0]["Value"] = fnHistory;
            dt.Select("Name='enOrganigrame'")[0]["Value"] = Request.Form["ctl00$main$enOrganigrame"];
            dt.Select("Name='frOrganigrame'")[0]["Value"] = Request.Form["ctl00$main$frOrganigrame"];
            dt.Select("Name='arOrganigrame'")[0]["Value"] = Request.Form["ctl00$main$arOrganigrame"];
            string fnOrganigrame = "";
            if (thumbOrganigrame.HasFile)
            {
                var ext = System.IO.Path.GetExtension(thumbOrganigrame.FileName);
                if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                {
                    fnOrganigrame = Guid.NewGuid().ToString() + ext;
                    string path = Server.MapPath("~/Media/Organigrame");
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    try
                    {
                        File.Delete(path + "/" + dt.Select("Name='thumbOrganigrame'")[0]["Value"]);
                    }
                    catch { }
                    thumbOrganigrame.SaveAs(Server.MapPath("~/Media/Organigrame/" + fnOrganigrame));
                }

            }
            else
            {
                fnOrganigrame = dt.Select("Name='thumbOrganigrame'")[0]["Value"].ToString();
            }
            dt.Select("Name='thumbOrganigrame'")[0]["Value"] = fnOrganigrame;
            dt.Select("Name='enMission'")[0]["Value"] = Request.Form["ctl00$main$enMission"];
            dt.Select("Name='frMission'")[0]["Value"] = Request.Form["ctl00$main$frMission"];
            dt.Select("Name='arMission'")[0]["Value"] = Request.Form["ctl00$main$arMission"];
            dt.Select("Name='enAffairEstudiantine'")[0]["Value"] = Request.Form["ctl00$main$enAffairEstudiantine"];
            dt.Select("Name='frAffairEstudiantine'")[0]["Value"] = Request.Form["ctl00$main$frAffairEstudiantine"];
            dt.Select("Name='arAffairEstudiantine'")[0]["Value"] = Request.Form["ctl00$main$arAffairEstudiantine"];
            dt.Select("Name='enOrientation'")[0]["Value"] = Request.Form["ctl00$main$enOrientation"];
            dt.Select("Name='frOrientation'")[0]["Value"] = Request.Form["ctl00$main$frOrientation"];
            dt.Select("Name='arOrientation'")[0]["Value"] = Request.Form["ctl00$main$arOrientation"];
            dt.Select("Name='enHrOrganigrame'")[0]["Value"] = Request.Form["ctl00$main$enHrOrganigrame"];
            dt.Select("Name='frHROrganigrame'")[0]["Value"] = Request.Form["ctl00$main$frHROrganigrame"];
            dt.Select("Name='arHROrganigrame'")[0]["Value"] = Request.Form["ctl00$main$arHROrganigrame"];
            string fnHROrganigrame = "";
            if (thumbHROrganigrame.HasFile)
            {
                var ext = System.IO.Path.GetExtension(thumbHROrganigrame.FileName);
                if (ext != ".exe" && ext != ".aspx" && ext != "php" && ext != "asp")
                {
                    fnHROrganigrame = Guid.NewGuid().ToString() + ext;
                    string path = Server.MapPath("~/Media/HROrganigrame");
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    try
                    {
                        File.Delete(path + "/" + dt.Select("Name='thumbHROrganigrame'")[0]["Value"]);
                    }
                    catch { }
                    thumbHROrganigrame.SaveAs(Server.MapPath("~/Media/HROrganigrame/" + fnHROrganigrame));
                }

            }
            else
            {
                fnHROrganigrame = dt.Select("Name='thumbHROrganigrame'")[0]["Value"].ToString();
            }
            dt.Select("Name='thumbHROrganigrame'")[0]["Value"] = fnHROrganigrame;
            dt.Select("Name='enConseil'")[0]["Value"] = Request.Form["ctl00$main$enConseil"];
            dt.Select("Name='frConseil'")[0]["Value"] = Request.Form["ctl00$main$frConseil"];
            dt.Select("Name='arConseil'")[0]["Value"] = Request.Form["ctl00$main$arConseil"];
            dt.Select("Name='enEmployment'")[0]["Value"] = Request.Form["ctl00$main$enEmployment"];
            dt.Select("Name='frEmployment'")[0]["Value"] = Request.Form["ctl00$main$frEmployment"];
            dt.Select("Name='arEmployment'")[0]["Value"] = Request.Form["ctl00$main$arEmployment"];
            dt.Select("Name='enAlumni'")[0]["Value"] = Request.Form["ctl00$main$enAlumni"];
            dt.Select("Name='frAlumni'")[0]["Value"] = Request.Form["ctl00$main$frAlumni"];
            dt.Select("Name='arAlumni'")[0]["Value"] = Request.Form["ctl00$main$arAlumni"];

            ds.WriteXml(Server.MapPath("~/cms/config.config"));
            Response.Redirect("settings.aspx");
        }
    }
}