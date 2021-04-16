<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwResultados.aspx.cs" Inherits="Templeate_LIN.retrabajos.rwResultados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="mdl-grid ui-tables">
          
            <div class="mdl-cell mdl-cell--12-col-desktop mdl-cell--12-col-tablet mdl-cell--4-col-phone">
                <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h1 class="mdl-card__title-text">Resultados de busqueda </h1>
                    </div>
                    <div class="mdl-card__supporting-text no-padding">
                        <table class="mdl-data-table mdl-js-data-table stripped-table">
                            <thead>
                            <tr>
                                <th class="mdl-data-table__cell--non-numeric">Operacion</th>
                                <th class="mdl-data-table__cell--non-numeric">Solicitante</th>
                                <th class="mdl-data-table__cell--non-numeric">Inicio</th>
                                <th class="mdl-data-table__cell--non-numeric">Modelo</th>
                                <th class="mdl-data-table__cell--non-numeric">Maquina SN</th>
                                <th class="mdl-data-table__cell--non-numeric">Coldplate SN</th>
                                <th class="mdl-data-table__cell--non-numeric">Motivo</th>
                            </tr>
                            </thead>
                            <tbody id="cuerpoTablaBusqueda" runat="server">
                             
                             </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </div>

</asp:Content>
