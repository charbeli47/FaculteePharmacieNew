﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class graduation_categories : System.Web.UI.Page
    {
        protected dynamic result;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetGraduationCategories().ToArray();
        }
    }
}