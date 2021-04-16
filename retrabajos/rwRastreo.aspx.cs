using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{
    public partial class rwRastreo : System.Web.UI.Page
    {
        CRUD crud = new CRUD();
        SECURITY seguridad = new SECURITY();
        MAIL correo = new MAIL();

        protected void Page_Load(object sender, EventArgs e)
        {
            seguridad.verify();

        }



        protected void rwBusquedaRWID(object sender, EventArgs e)
        {
        
        }


        protected void rwBusquedaColdplateSN(object sender, EventArgs e)
        {
            
        }


        protected void rwBusquedaMachineSN(object sender, EventArgs e)
        {

        }
    }
}