using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{
    public partial class rwHospital : System.Web.UI.Page
    {
        security seguridad = new security();
        protected void Page_Load(object sender, EventArgs e)
        {
            seguridad.verify();
        }
    }
}