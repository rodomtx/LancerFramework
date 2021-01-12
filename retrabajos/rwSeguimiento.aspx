<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwSeguimiento.aspx.cs" Inherits="Templeate_LIN.retrabajos.rwSeguimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="mdl-grid ui-buttons">

                        <div class="mdl-cell mdl-cell--6-col-desktop mdl-cell--6-col-tablet mdl-cell--4-col-phone">
                <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h1 class="mdl-card__title-text">Detalles Retrabajo</h1>
                    </div>
                    <div class="mdl-card__supporting-text no-padding">
                        <table class="mdl-data-table mdl-js-data-table stripped-table">
                            <tbody id="cuerpoTablaRetrabajos" runat="server">
                             <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>ID Retrabajo</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>62</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr>
                             <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Modelo Maquina</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>85-544</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr>
                            <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Serie Maquina</strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>ZLN1324</td>
                                    <td class='mdl-data-table__cell--non-numeric'></td>
                             </tr> 
                            <tr>
                                    <td class='mdl-data-table__cell--non-numeric'><strong>Serie Cold Plate </strong></td>
                                    <td class='mdl-data-table__cell--non-numeric'>013268</td>
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
                             </tr>
                             
                              
                            </tbody>
                        
                        </table>
                    </div>
                </div>
            </div>
   </div>
           
</asp:Content>


