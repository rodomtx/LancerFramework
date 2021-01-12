using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;


namespace Templeate_LIN
{
    public partial class signin : System.Web.UI.Page
    {
        security seguridad = new security();
        protected void Page_Load(object sender, EventArgs e)
        {
            
              
        }

        protected void signinService(object sender, EventArgs e)
        {

            if (seguridad.validarCredenciales(email.Value,password.Value)!=-1)
            {
                Session["auth"] = "true";
                Session["correo"] = email.Value;
                Session["grupoSeguridad"] = seguridad.validarCredenciales(email.Value, password.Value);
                Session["nombre"] = "Rodolfo";

                if (Session["pathBeforeSignin"] != null)
                {
                    Response.Redirect(Session["pathBeforeSignin"].ToString());
                }
                else
                {
                    Response.Redirect("/Default.aspx"); 
                }
                


            }
            else
            {
                mensajes.InnerHtml = "<p> <span class='color-text--red'>Invalid Credentials</span></p>";
            }


        }
        private static byte[] GetSHA1(string userID, string password)
        {
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            return sha.ComputeHash(System.Text.Encoding.ASCII.GetBytes(userID + password));
        }
    }


}