<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwRastreo.aspx.cs" Inherits="Templeate_LIN.retrabajos.rwRastreo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="mdl-grid ui-components">
    <form action="#" class="mdl-grid ui-components" runat="server">
       <div class="mdl-cell mdl-cell--4-col-desktop mdl-cell--6-col-tablet mdl-cell--4-col-phone">
                <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h2 class="mdl-card__title-text">
                            <div id="tt1" class="icon material-icons color-text--green">search</div>
                                <div class="mdl-tooltip" data-mdl-for="tt1">
                                   Buscar retrabajo por:
                                </div>
                            &nbsp;Buscar retrabajo por:</h2>
                    </div>
                    <div class="mdl-card__supporting-text">
                     <h3 class="text-color--smooth-gray">Serie de la maquina</h3>
                   <div class="mdl-textfield mdl-js-textfield full-size">
                                        <input class="mdl-textfield__input" type="text" id="machinesn" runat="server">
                                        <label class="mdl-textfield__label" for="first-name">Serie Maquina</label>
                                    </div>
                           
                        
                    <button class="mdl-button mdl-js-button mdl-button--icon mdl-button--raised mdl-js-ripple-effect button--colored-green" runat="server" OnServerClick="rwBusquedaMachineSN">
                                    <i class="material-icons">search</i>
                                    
                                </button>
                         
                    </div>
                 </div>
    </div>
    <div class="mdl-cell mdl-cell--4-col-desktop mdl-cell--6-col-tablet mdl-cell--4-col-phone">
                <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h2 class="mdl-card__title-text">
                            <div id="tt1" class="icon material-icons color-text--green">search</div>
                                <div class="mdl-tooltip" data-mdl-for="tt1">
                                   
                                </div>
                            &nbsp;Buscar retrabajo por:</h2>
                     </div>
                        <div class="mdl-card__supporting-text">
                     <h3 class="text-color--smooth-gray">Serie coldplate</h3>
                  <div class="mdl-textfield mdl-js-textfield full-size">
                                        <input class="mdl-textfield__input" type="text" id="coldplate" runat="server">
                                        <label class="mdl-textfield__label" for="first-name">Serie coldplate</label>
                                    </div>
                             
                            
                             <button class="mdl-button mdl-js-button mdl-button--icon mdl-button--raised mdl-js-ripple-effect button--colored-green" runat="server" OnServerClick="rwBusquedaColdplateSN">
                                    <i class="material-icons">search</i>
                                    
                                </button>
                         
                         
                        </div>
                </div>
    </div>

    <div class="mdl-cell mdl-cell--4-col-desktop mdl-cell--6-col-tablet mdl-cell--4-col-phone">
                <div class="mdl-card mdl-shadow--2dp">
                    <div class="mdl-card__title">
                        <h2 class="mdl-card__title-text"> 
                            <div id="tt1" class="icon material-icons color-text--green">search</div>
                                <div class="mdl-tooltip" data-mdl-for="tt1">
                                   
                                </div>
                            &nbsp;Buscar retrabajo por:

                        </h2>
                     </div>
                     <div class="mdl-card__supporting-text">
                     <h3 class="text-color--smooth-gray">Orden de retrabajo</h3>
                  <div class="mdl-textfield mdl-js-textfield full-size">
                                        <input class="mdl-textfield__input" type="text" id="retrabajo" runat="server">
                                        <label class="mdl-textfield__label" for="first-name">Orden de retrabajo</label>
                                    </div>
                           
                         
                         <button class="mdl-button mdl-js-button mdl-button--icon mdl-button--raised mdl-js-ripple-effect button--colored-green" runat="server" OnServerClick="rwBusquedaRWID">
                                    <i class="material-icons">search</i>
                                    
                                </button>
                     </div>
                   </div>
      
    </div>
    </form>  
        </div>
</asp:Content>
