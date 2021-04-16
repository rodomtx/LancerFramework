<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwHospital.aspx.cs" Inherits="Templeate_LIN.retrabajos.rwHospital" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="mdl-grid ui-tables">
          
            <div class="mdl-cell mdl-cell--12-col-desktop mdl-cell--12-col-tablet mdl-cell--4-col-phone">
                <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h1 class="mdl-card__title-text">Retrabajos en transito</h1>
                    </div>
                    <div class="mdl-card__supporting-text no-padding">
                        <table class="mdl-data-table mdl-js-data-table stripped-table">
                            <thead>
                            <tr>
                                <th class="mdl-data-table__cell--non-numeric">Operacion</th>
                                <th class="mdl-data-table__cell--non-numeric">Area</th>
                                <th class="mdl-data-table__cell--non-numeric">Solicitante</th>
                                <th class="mdl-data-table__cell--non-numeric">Inicio</th>
                                <th class="mdl-data-table__cell--non-numeric">Asignacion Journal</th>
                                <th class="mdl-data-table__cell--non-numeric">Recibo Hospital</th>
                                <th class="mdl-data-table__cell--non-numeric">Recibo Fundidora</th>
                                <th class="mdl-data-table__cell--non-numeric">Revision Fundidora</th>
                                <th class="mdl-data-table__cell--non-numeric">Regreso Hospital</th>
                                <th class="mdl-data-table__cell--non-numeric">Inspeccion Final</th>
                                <th class="mdl-data-table__cell--non-numeric">Modificar</th>
                            </tr>
                            </thead>
                            <tbody id="cuerpoTablaRetrabajos" runat="server">
                             
                             </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </div>
</asp:Content>
