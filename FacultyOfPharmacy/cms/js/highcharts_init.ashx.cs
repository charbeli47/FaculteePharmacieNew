using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utils;

namespace FacultyOfPharmacy.cms.js
{
    /// <summary>
    /// Summary description for hightcharts_init
    /// </summary>
    public class hightcharts_init : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/javascript";
            dcDataContext dc = new dcDataContext();
            string script = "$(function () {" +
    "var chart;" +
    "$(document).ready(function() {" +
    "Highcharts.setOptions({" +
        "colors: ['#32353A']" +
    "});" +
        "chart = new Highcharts.Chart({" +
            "chart: {" +
                "renderTo: 'container'," +
                "type: 'column'," +
                "margin: [ 50, 30, 80, 60]" +
            "}," +
            "title: {" +
                "text: 'Visits this month'" +
            "}," +
            "xAxis: {";
            //int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                string s = "";
            for(int i=1;i<=DateTime.Now.Day;i++)
            {
            string date = string.Format("{0}-{1}-{2}",i,DateTime.Now.Month,DateTime.Now.Year);
                s+=",'"+date+"'";
            }
            if(s.Length>0)
                s = s.Substring(1);
            script += "categories: [" + s + "]," +
            "labels: {" +
                "rotation: -45," +
                "align: 'right'," +
                "style: {" +
                    "fontSize: '9px'," +
                    "fontFamily: 'Tahoma, Verdana, sans-serif'" +
                "}" +
            "}" +
        "}," +
        "yAxis: {" +
            "min: 0," +
            "title: {" +
                "text: 'Visits'" +
            "}" +
        "}," +
        "legend: {" +
            "enabled: false" +
        "}," +
        "tooltip: {" +
            "formatter: function() {" +
                "return '<b>'+ this.x +'</b><br/>'+" +
                    "'Visits: '+ Highcharts.numberFormat(this.y, 0);" +
            "}" +
        "}," +
            "series: [{" +
            "name: 'Visits',";
            string svalues = "";
            for (int i = 1; i <= DateTime.Now.Day; i++)
            {
                string date = string.Format("{0}/{1}/{2}", DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString(), i.ToString().Length==1?"0"+i.ToString():i.ToString(), DateTime.Now.Year);
                var resdate = dc.CMSGetVisitsPerDate(date).Single();
                svalues += ","+resdate.visits;
            }
            if (svalues.Length > 0)
                svalues = svalues.Substring(1);
                script +="data: ["+svalues+"],"+
                "dataLabels: {"+
                    "enabled: false,"+
                    "rotation: 0,"+
                    "color: '#F07E01',"+
                    "align: 'right',"+
                    "x: -3,"+
                    "y: 20,"+
                    "formatter: function() {"+
                        "return this.y;"+
                    "},"+
                    "style: {"+
                        "fontSize: '11px',"+
                        "fontFamily: 'Verdana, sans-serif'"+
                    "}"+
                "}, "+
                "pointWidth: 20"+
            "}]"+
        "});" +
    "});"+
    
"});";
            context.Response.Write(script);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}