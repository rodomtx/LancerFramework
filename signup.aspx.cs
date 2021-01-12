using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Templeate_LIN
{
    public partial class signup : System.Web.UI.Page
    {
        security seguridad = new security();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void signupService(object sender, EventArgs e)
        {

            if (seguridad.crearUsuario(name.Value, email.Value, password.Value))
            {
                Response.Redirect("/Default.aspx");
            }
            else
            {
                mensajes.InnerHtml += "<br><p> No fue posible crear el usuario</p>";
            }


        }
    }
}