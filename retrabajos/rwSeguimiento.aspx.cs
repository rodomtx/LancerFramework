using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Templeate_LIN.retrabajos
{

    public partial class rwSeguimiento : System.Web.UI.Page
    {
        CRUD crud = new CRUD();
        SECURITY seguridad = new SECURITY();

        protected void Page_Load(object sender, EventArgs e)
        {
            seguridad.verify();


            if (!string.IsNullOrEmpty(Request.QueryString["rwID"]))
            {
                int rwID = Int32.Parse(Request.QueryString["rwID"]);

                
                foreach (REWORKDETAILS rd in crud.detallesReworkItemas(rwID))
                {
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Operacion</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>"+ rd.operacionSeq.ToString() +"</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr>";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Area Solicita</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.area.ToString() + "</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr>";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Solicita</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>"+rd.originador.ToString()+"</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr> ";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Modelo Maquina</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>"+rd.machinePN.ToString()+"</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr> ";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Serie Maquina</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>"+rd.machineSN.ToString()+"</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr> ";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Serie Cold Plate</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>"+rd.coldplateSN+"</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr> ";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Comentarios</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>"+rd.descripcion+"</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr>";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Inicio</strong></td>";
                    
                    if ( (rd.fechaCreacion.Year== DateTime.Now.Year) && (rd.fechaCreacion.Day == DateTime.Now.Day) && (rd.fechaCreacion.Month == DateTime.Now.Month ) )
                        {
                        detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.fechaCreacion.ToString("hh:mm tt") + "</td>";

                    }
                    else
                    {
                        detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.fechaCreacion.ToString("MMM dd yy HH:mm tt") + "</td>";

                    }



                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr>";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";
                    detallesRetrabajo.InnerHtml += "                            ";


                }
                        


                

                
                
           
            
            
            
            }

            
        }

        void aviso()
        {
            avisos.InnerHtml += "<p> <span class='color-text--green'>" + Request.QueryString["rwID"] + "</span></p>";
        }
    }
}