using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U4_W3_D1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVisualizza_Click(object sender, EventArgs e)
        {
           
            NomeCandidato.Text = ConfigurationManager.AppSettings["NomeCandidato"];
            CognomeCandidato.Text = ConfigurationManager.AppSettings["CognomeCandidato"];
        }
    }
}