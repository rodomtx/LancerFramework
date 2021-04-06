using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Templeate_LIN
{
    public class SECURITY
    {
        string auth;
        string usuario;
        int grupoSeguridad;
        
        public SECURITY()
        { 
            
        }

        public void verify()
        {
            if (System.Web.HttpContext.Current.Session["auth"] != null)
            {
               
            }
            else
            {
                System.Web.HttpContext.Current.Session["pathBeforeSignin"] = System.Web.HttpContext.Current.Request.Url.LocalPath;
                System.Web.HttpContext.Current.Response.Redirect("/signin.aspx");

            }
        }

        public bool crearUsuario(string usuario, string email ,string contrasena)
        {
            CRUD crud = new CRUD();

            bool ans = false;

            if (crud.crearusuario(usuario, email, generarHash(email, contrasena)))
            {
                ans = true;
            }
            else
            {
                ans = false;
            }
            return ans;
        }

        public int validarCredenciales(string _correo,string  _password)
        {
            CRUD crud = new CRUD();

            int ans = -1;

            ans = crud.validarCredenciales(_correo, generarHash(_correo, _password));

            this.grupoSeguridad = ans;

            return ans;
        }

        public string generarHash(string usuario, string contrasena)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(usuario+contrasena);
            byte[] md5pw = md5.ComputeHash(data);


            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < md5pw.Length; i++)
            {
                ans.Append(md5pw[i].ToString("X2"));
            }


            return ans.ToString();
        }
      
        public bool VerificarAcceso(string _correo, int _permiso)
        {
            CRUD crud = new CRUD();

            bool ans = false;

            ans = crud.verificarAcceso(_correo, _permiso);

            return ans;
        }


    }
}
