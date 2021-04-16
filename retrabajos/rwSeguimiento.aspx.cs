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
        
        bool lastOp = true;

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
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.operacionSeq.ToString() + "</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr>";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Area Solicita</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.area.ToString() + "</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr>";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Solicita</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.originador.ToString() + "</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr> ";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Modelo Maquina</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.machinePN.ToString() + "</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr> ";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Serie Maquina</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.machineSN.ToString() + "</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr> ";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Serie Cold Plate</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.coldplateSN + "</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr> ";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Comentarios</strong></td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.descripcion + "</td>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr>";
                    detallesRetrabajo.InnerHtml += "                            <tr>";
                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'><strong>Inicio</strong></td>";

                    if (esHoy(rd.fechaCreacion))
                    {
                        detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.fechaCreacion.ToString("hh:mm tt") + "</td>";
                    }
                    else
                    {
                        detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'>" + rd.fechaCreacion.ToString("MMM dd yy HH:mm tt") + "</td>";
                    }

                    detallesRetrabajo.InnerHtml += "                            <td class='mdl-data-table__cell--non-numeric'></td>";
                    detallesRetrabajo.InnerHtml += "                            </tr>";
                    // Jouranl
                    detallesRetrabajo.InnerHtml += formatoCamposFechas(rd.fechaJournal, "Captura Journal", rwID);
                    // Ingreso a hospital
                    detallesRetrabajo.InnerHtml += formatoCamposFechas(rd.ingresoHospital, "Ingreso Hospital", rwID);
                    detallesRetrabajo.InnerHtml += formatoCamposFechas(rd.ingresFundidora, "Ingreso Fundidora", rwID);
                    detallesRetrabajo.InnerHtml += formatoCamposFechas(rd.revisionFundidora, "Revision Fundidora", rwID);
                    detallesRetrabajo.InnerHtml += formatoCamposFechas(rd.retornoHospital, "Retorno Hospital", rwID);
                    detallesRetrabajo.InnerHtml += formatoCamposFechas(rd.inspeccionFinal, "Inspeccion final", rwID);
                    detallesRetrabajo.InnerHtml += formatoCamposFechas(rd.entregada, "Entregada", rwID);

                }

            }
            else
            {
                Response.Redirect("/retrabajos/rwInventory.aspx");

            }
            
        }


        string formatoCamposFechas(DateTime _fecha, string _titulo,int _rwID)
        {
            string ans = "                            <tr>";
                   ans += "                            <td class='mdl-data-table__cell--non-numeric'><strong>" + _titulo + "</strong></td>"; ;

            if (_fecha.Year < 1983)
            {
                ans += "                            <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--red'>Pendiente</span></td>";
                if (!lastOp)
                {
                    ans += "                            <td class='mdl-data-table__cell--non-numeric'><i class='material-icons'>lock</i></a></td>";
                }
                else
                {
                    ans += "                            <td class='mdl-data-table__cell--non-numeric'><a href='/retrabajos/rwUpdate.aspx?rwID=" + _rwID.ToString() + "&rwOp=" + _titulo.Replace(" ","_") + "'><i class='material-icons'>create</i></a></td>";
                }
                ans  += "                            </tr>";
                lastOp = false;  
            }
            else
            {
                lastOp = true;

                if (esHoy(_fecha))
                {
                    ans  += "                            <td class='mdl-data-table__cell--non-numeric'>" + _fecha.ToString("hh:mm tt") + "</td>";
                    ans  += "                            <td class='mdl-data-table__cell--non-numeric'><i class='material-icons'>check</i></a></td>";
                    ans  += "                            </tr>";
                }
                else
                {
                    ans  += "                            <td class='mdl-data-table__cell--non-numeric'>" + _fecha.ToString("MMM dd yy HH:mm tt") + "</td>";
                    ans  += "                            <td class='mdl-data-table__cell--non-numeric'><i class='material-icons'>check</i></a></td>";
                    ans  += "                            </tr>";
                }

            }

            return ans;    
        }

        bool esHoy(DateTime _fecha)
        {
            bool ans = false;
            if ( (_fecha.Year == DateTime.Now.Year) && (_fecha.Day == DateTime.Now.Day) && (_fecha.Month == DateTime.Now.Month))
            {
                ans = true;
            }
            else
            {
                ans = false;
            }


            return ans;
        
        }
        void aviso()
        {
            avisos.InnerHtml += "<p> <span class='color-text--green'>" + Request.QueryString["rwID"] + "</span></p>";
        }
    }
}