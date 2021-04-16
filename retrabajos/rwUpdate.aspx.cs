using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{
    public partial class rwUpdate : System.Web.UI.Page
    {
        CRUD crud = new CRUD();
        SECURITY seguridad = new SECURITY();
        MAIL correo = new MAIL();
        int rwID;
        string rwOp;


        protected void Page_Load(object sender, EventArgs e)
        {
            seguridad.verify();

            if (!string.IsNullOrEmpty(Request.QueryString["rwID"]))
            {
                rwID = Int32.Parse(Request.QueryString["rwID"]);
                rwOp = Request.QueryString["rwOP"].ToString();

                titulo.InnerText = "Actualizacion informacion retrabajo: " + rwID.ToString() ;
                tarea.InnerText = "Tarea :  " + rwOp.Replace("_", " ");
            
            }
            else
            { Response.Redirect("/retrabajos/rwInventory.aspx"); }
        
        }


        string traducirOperaciones(string _rwOp)
        {
            string ans = "";

            switch (_rwOp)
            {
                case "Captura_Journal":
                    ans = "020";
                    break;
                case "Ingreso_Hospital":
                    ans = "030";
                    break;
                case "Ingreso_Fundidora":
                    ans = "040";
                    break;
                case "Revision_Fundidora":
                    ans = "050";
                        break;
                case "Retorno_Hospital":
                    ans = "060";
                    break;
                case "Inspeccion_final":
                    ans = "070";
                    break;
                case "Entregada":
                    ans = "080";
                    break;
                default:
                    ans = "unknown";
                    break;


            }

            return ans;
        }

        int operacionesPermisos(string _rwOp)
        {
            int ans  ;

            switch (_rwOp)
            {
                case "Captura_Journal":
                    ans = 2;
                    break;
                case "Ingreso_Hospital":
                    ans = 3;
                    break;
                case "Ingreso_Fundidora":
                    ans = 4;
                    break;
                case "Revision_Fundidora":
                    ans = 5;
                    break;
                case "Retorno_Hospital":
                    ans = 6;
                    break;
                case "Inspeccion_final":
                    ans = 7;
                    break;
                case "Entregada":
                    ans = 8;
                    break;
                default:
                    ans = 0;
                    break;


            }

            return ans;
        }
       
        protected void actualizarRW(object sender, EventArgs e)
        {
            if (seguridad.VerificarAcceso(Session["correo"].ToString(), operacionesPermisos(rwOp)))
            {
                crud.actualizarRetrabajo(rwID, traducirOperaciones(rwOp), "", Session["correo"].ToString());
                
            
            foreach (string direccion in crud.listaCorreosPermiso((operacionesPermisos(rwOp)+1).ToString()))
            {
                    correo.notificacionTarea(direccion, rwOp.Replace("_"," "), rwID.ToString());   
                
                }

                Response.Redirect("/retrabajos/rwInventory.aspx");
            }
            else
            {
                avisos.InnerHtml = "<p> <span class='color-text--green'>La cuenta no tiene privilegios para realizar esta operacion.</span></p>";
            }

                
        }
    }
}