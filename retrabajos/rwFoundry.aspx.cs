using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{
    public partial class rwFoundry : System.Web.UI.Page
    {
       
            CRUD crud = new CRUD();
            SECURITY seguridad = new SECURITY();

            protected void Page_Load(object sender, EventArgs e)
            {
                seguridad.verify();


                tabla();

            }

            void tabla()
            {
                foreach (REWORK ri in crud.listaReworkFundidora())
                {
                    cuerpoTablaRetrabajos.InnerHtml += "                            <tr>";
                    cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>" + ri.operacionSeq + "</td>";
                    cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>" + ri.lineaSolicita + "</td>";
                    cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>" + ri.originador + "</td>";

                    if (esHoy(ri.fechaCreacion))
                    {



                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>" + ri.fechaCreacion.ToString("hh:mm tt") + "</td>";
                    }
                    else
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'>" + ri.fechaCreacion.ToString("MMM dd hh:mm tt") + "</td>";
                    }



                    if (ri.journalGeneradoMedida != "vacio")
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.journalGeneradoFlag + "'>" + ri.journalGenerado + " " + ri.journalGeneradoMedida + "</span> </td>";
                    }
                    else
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--gray'> - </span> </td>";
                    }

                    if (ri.hospitalReciboMedida != "vacio")
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.hospitalReciboFlag + "'>" + ri.hospitalRecibo + " " + ri.hospitalReciboMedida + "</span> </td>";
                    }
                    else
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--gray'> - </span> </td>";
                    }

                    if (ri.fundidoraReciboMedida != "vacio")
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.fundidoraReciboFlag + "'>" + ri.fundidoraRecibo + " " + ri.fundidoraReciboMedida + "</span> </td>";
                    }
                    else
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--gray'> - </span> </td>";
                    }

                    if (ri.revisionFundidoraMedida != "vacio")
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.revisionFundidoraFlag + "'>" + ri.revisionFundidora + " " + ri.revisionFundidoraMedida + "</span> </td>";
                    }
                    else
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--gray'> - </span> </td>";
                    }

                    if (ri.retornoHospitalMedida != "vacio")
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.retornoHospitalflag + "'>" + ri.retornoHospital + " " + ri.retornoHospitalMedida + "</span> </td>";
                    }
                    else
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--gray'> - </span> </td>";
                    }

                    if (ri.inseccionHospitalMedida != "vacio")
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--" + ri.inseccionHospitalflag + "'>" + ri.inseccionHospital + " " + ri.inseccionHospitalMedida + "</span> </td>";
                    }
                    else
                    {
                        cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--gray'> - </span> </td>";
                    }


                    cuerpoTablaRetrabajos.InnerHtml += "                               <td class='mdl-data-table__cell--non-numeric'><a href=/retrabajos/rwSeguimiento.aspx?rwID=" + ri.operacionSeq + "><i class='material-icons'>create</i></a></td>";
                    cuerpoTablaRetrabajos.InnerHtml += "                            </tr>";

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