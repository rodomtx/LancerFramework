using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{
    public partial class reRequest : System.Web.UI.Page
    {
        CRUD crud = new CRUD();
        SECURITY seguridad = new SECURITY();
        MAIL correo = new MAIL();

        protected void Page_Load(object sender, EventArgs e)
        {
            seguridad.verify();

            supervisor.Value = Session["correo"].ToString();
            
        
        foreach (AREA a in crud.listaAreas())
            { 
            area.Items.Add(agregarListItem(a.descripcion ,a.centroCostos));
            }

            foreach (RAZON r in crud.listaRazones())
            {
                ListRazones.Items.Add(agregarListItem(r.codigo.ToString(), r.descripcion));
            }

        }



        public ListItem agregarListItem(string _texto,string _value)
        { /* esta funcion se usa para generar el objeto ListItem con el atributo de la clase ,
           se usa agregar las areas al menu de areas
           */ 
            ListItem li = new ListItem();
            li.Text = _value; 
            li.Value = _texto;
            li.Attributes.Add("class", "mdl-menu__item");
            
            return li;

        }


        protected void solicitarRetrabajo(object sender, EventArgs e)
        {
            if (seguridad.VerificarAcceso(Session["correo"].ToString(), 1))
            {

                    correo.notificacionTarea(  Session["nombre"].ToString(),
                                                "Se necesita generar Journal",
                                                crud.solicitarRetrabajo("rework", machinePN.Value, machineSN.Value, coldplateSN.Value, supervisor.Value, area.SelectedValue, ListRazones.SelectedValue)
                                                );
                    Response.Redirect("/retrabajos/rwInventory.aspx");
            }
            else
            {
                avisos.InnerHtml+= "<p> <span class='color-text--green'>La cuenta no tiene privilegios para realizar esta operacion.</span></p>";
            }
        }


    }
}