<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwInventory.aspx.cs" Inherits="Templeate_LIN.retrabajos.rwInventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="mdl-grid ui-tables">

            
            <div class="mdl-cell mdl-cell--12-col-desktop mdl-cell--12-col-tablet mdl-cell--4-col-phone">
                <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h1 class="mdl-card__title-text">Rework Inventory</h1>
                    </div>
                    <div class="mdl-card__supporting-text no-padding">
                        <table class="mdl-data-table mdl-js-data-table stripped-table">
                            <thead>
                            <tr>
                                <th class="mdl-data-table__cell--non-numeric">#</th>
                                <th class="mdl-data-table__cell--non-numeric">Area</th>
                                <th class="mdl-data-table__cell--non-numeric">Owner</th>
                                <th class="mdl-data-table__cell--non-numeric">Started</th>
                                <th class="mdl-data-table__cell--non-numeric">Journal</th>
                                <th class="mdl-data-table__cell--non-numeric">Hospital Receive</th>
                                <th class="mdl-data-table__cell--non-numeric">Foundry Receive</th>
                                <th class="mdl-data-table__cell--non-numeric">Hospital Return</th>
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
