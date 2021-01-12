using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            spanNombre.InnerHtml = Session["nombre"].ToString();
            spanNombreMenu.InnerHtml = Session["nombre"].ToString();
            spanCorreo.InnerHtml = Session["correo"].ToString();
            
        }
    }
}