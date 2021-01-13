using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{
    public partial class rwInventory : System.Web.UI.Page
    {
        CRUD crud = new CRUD();
        security seguridad = new security();
        protected void Page_Load(object sender, EventArgs e)
        {
            seguridad.verify();
            
            
            tabla();
           
        }

        void tabla()
        {
            foreach (reworkItem ri in crud.listaReworkItems())
            {
                cuerpoTablaRetrabajos.InnerHtml += "                            <tr>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>"+ri.operacionSeq+"</td>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>"+ri.lineaSolicita+"</td>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>"+ri.owner+"</td>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>"+ri.fechaCreacion.ToString("MMM dd hh:mm tt")+"</td>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--"+ri.journalGeneradoFlag+"'>" + ri.journalGenerado+" "+ri.journalGeneradoMedida+"</span> </td>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.hospitalReciboFlag + "'>" + ri.hospitalRecibo + " " + ri.hospitalReciboMedida + "</span> </td>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.fundidoraReciboFlag+ "'>" + ri.fundidoraRecibo + " " + ri.fundidoraReciboMedida + "</span> </td>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.retornoHospitalflag + "'>" + ri.retornoHospital + " " + ri.retornoHospitalMedida + "</span> </td>";
                cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><a href=/retrabajos/rwSeguimiento.aspx?rwID=" + ri.operacionSeq + "><i class='material-icons'>create</i></a></td>";
                cuerpoTablaRetrabajos.InnerHtml += "                            </tr>";

            }




        }
    }
}