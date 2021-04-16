using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{
    public partial class rwResultados : System.Web.UI.Page
    {
        CRUD crud = new CRUD();
        SECURITY segubrwdad = new SECURITY();
        MAIL correo = new MAIL();

        protected void Page_Load(object sender, EventArgs e)
        {
            segubrwdad.verify();

            if (!string.IsNullOrEmpty(Request.QueryString["parametro"]))
            {

                string parametro = Request.QueryString["parametro"];
                string tipo = Request.QueryString["tipo"];
                tabla(parametro, tipo);


            }



            void tabla(string _parametro, string _tipo)
            {
                foreach (BUSQUEDARW brw in crud.listaBusqueda(_parametro, _tipo))
                {
                    cuerpoTablaBusqueda.InnerHtml += "                            <tr>";
                    cuerpoTablaBusqueda.InnerHtml += "                               <td class='mdl-data-table__cell--non-numebrwc'>" + brw.operacion.ToString() + "</td>";
                    cuerpoTablaBusqueda.InnerHtml += "                               <td class='mdl-data-table__cell--non-numebrwc'>" + brw.creator + "</td>";


                    if (esHoy(brw.creacion))
                    {



                        cuerpoTablaBusqueda.InnerHtml += "                               <td class='mdl-data-table__cell--non-numebrwc'>" + brw.creacion.ToString("hh:mm tt") + "</td>";
                    }
                    else
                    {
                        cuerpoTablaBusqueda.InnerHtml += "                               <td class='mdl-data-table__cell--non-numebrwc'>" + brw.creacion.ToString("MMM dd hh:mm tt") + "</td>";
                    }



                    cuerpoTablaBusqueda.InnerHtml += "                               <td class='mdl-data-table__cell--non-numebrwc'>" + brw.machinePN + "</td>";
                    cuerpoTablaBusqueda.InnerHtml += "                               <td class='mdl-data-table__cell--non-numebrwc'>" + brw.machineSN + "</td>";
                    cuerpoTablaBusqueda.InnerHtml += "                               <td class='mdl-data-table__cell--non-numebrwc'>" + brw.coldplateSN + "</td>";
                    cuerpoTablaBusqueda.InnerHtml += "                               <td class='mdl-data-table__cell--non-numebrwc'>" + brw.descripcion + "</td>";
                    cuerpoTablaBusqueda.InnerHtml += "                            </tr>";

                }

            }

            bool esHoy(DateTime _fecha)
            {
                bool ans = false;
                if ((_fecha.Year == DateTime.Now.Year) && (_fecha.Day == DateTime.Now.Day) && (_fecha.Month == DateTime.Now.Month))
                {
                    ans = true;
                }
                else
                {
                    ans = false;
                }


                return ans;

            }

        }
    }
}