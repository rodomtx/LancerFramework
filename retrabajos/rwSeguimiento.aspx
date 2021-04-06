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
                            <tbody id="detallesRetrabajo" runat="server">
                              
                            </tbody>
                        
                        </table>
                    </div>
                </div>
            </div>
   </div>
           
</asp:Content>


