using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SECURITY seguridad = new SECURITY();

        protected void Page_Load(object sender, EventArgs e)
        {

            seguridad.verify();

        }
        
    }
    
}