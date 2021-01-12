using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{
   
    public partial class rwSeguimiento : System.Web.UI.Page
    {
        CRUD crud = new CRUD();
        security seguridad = new security();

        protected void Page_Load(object sender, EventArgs e)
        {
            seguridad.verify();

        }
    }
}