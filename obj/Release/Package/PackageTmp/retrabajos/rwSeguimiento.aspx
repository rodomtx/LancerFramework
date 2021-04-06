<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwSeguimiento.aspx.cs" Inherits="Templeate_LIN.retrabajos.rwSeguimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="mdl-grid ui-buttons">

                        <div class="mdl-cell mdl-cell--6-col-desktop mdl-cell--6-col-tablet mdl-cell--4-col-phone">
                <div id="avisos" runat="server"></div>
                            <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h1 class="mdl-card__title-text">Detalles Retrabajo</h1>
                    </div>
                    <div class="mdl-card__supporting-text no-padding">
                        <table class="mdl-data-table mdl-js-data-table stripped-table">
                            <tbody id="cuerpoTablaRetrabajos" runat="server">
                             <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Operacion</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'><asp:Label runat="server" ID="idRetrabajo"></asp:Label></td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr>
                             <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Area Solicita</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>Ice Cool</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr>
                            <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Solicita</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>Rodolfo Martinez</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr> 
                            <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Modelo Maquina</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>85-2348-111/2</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr> 
                            <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Serie Maquina</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>ZLN101230</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr> 
                             <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Serie Cold Plate</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>000123546</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr> 
                             <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Comentarios</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>El plato presento fugas en fittings</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr> 
                             <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Inicio</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>Jan 14 07:37 AM</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr> 
                             
                                <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Journal</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--red'>Pendiente</span></td>
                                    <td class='mdl-data-table__cell--non-numeric'>
                                         <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-green">
                                            <i class="material-icons">create</i>
                                             Agregar
                                        </button>
                                    </td>
                                </tr>
                                <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Recibo Hospital</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--red'>Pendiente</span></td>
                                    <td class='mdl-data-table__cell--non-numeric'>
                                        <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-green"   disabled>
                                        <i class="material-icons">receipt</i>
                                            Recibir
                                    </button>
                                    </td>
                             </tr>
                                 <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Recibo Fundidora</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--red'>Pendiente</span></td>
                                    
                                    <td class='mdl-data-table__cell--non-numeric'>
                                        <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-green"   disabled>
                                        <i class="material-icons">receipt</i>
                                            Recibir
                                    </button>
                                    </td>
                              <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Asignar Operaciones</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--red'>Pendiente</span></td>
                                    
                                    <td class='mdl-data-table__cell--non-numeric'>
                                        <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-green"   disabled>
                                        <i class="material-icons">receipt</i>
                                           Asignar
                                    </button>
                                    </td>
                                 </tr>
                             <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Regreso Hospital</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--red'>Pendiente</span></td>
                                    <td class='mdl-data-table__cell--non-numeric'>
                                        <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-green"   disabled>
                                        <i class="material-icons">receipt</i>
                                            Recibir
                                    </button>
                                    </td>
                                 </tr>
                               <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Revision Hospital</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--red'>Pendiente</span></td>
                                    <td class='mdl-data-table__cell--non-numeric'>
                                        <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-green"   disabled>
                                        <i class="material-icons">receipt</i>
                                            Revisado
                                    </button>
                                    </td>
                                 </tr>
                               <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Aceptacion </strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'><span class='label label--mini color--red'>Pendiente</span></td>
                                    <td class='mdl-data-table__cell--non-numeric'>
                                        <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect button--colored-green"   disabled>
                                        <i class="material-icons">receipt</i>
                                            Aceptar
                                    </button>
                                    </td>
                                 </tr>
                             
                              
                            </tbody>
                        
                        </table>
                    </div>
                </div>
            </div>
   </div>
           
</asp:Content>


