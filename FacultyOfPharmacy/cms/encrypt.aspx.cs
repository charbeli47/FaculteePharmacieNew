using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class encrypt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void encryptText(object sender, EventArgs e)
        {
            encryptionField.Text = Encryptor.MD5Hash(inputField.Text);
        }
    }
}