<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwRequest.aspx.cs" Inherits="Templeate_LIN.retrabajos.reRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <div class="mdl-card mdl-shadow--2dp employer-form" action="#">
        
        <div id="avisos" runat="server"></div>
        <div class="mdl-card__title" >
            <!--- Titulo Subtitulo de la forma --->
           
            <h2>Solicitar retrabajo</h2>
                   <div class="mdl-card__subtitle">Por favor complete los datos de la solicitud</div>
                </div>
            
                <div class="mdl-card__supporting-text">
                    <form action="#" class="form" runat="server">
                        <div class="form__article">
                        <!--- Separador Seccion Finish Goos --->
                            <h3>Finish Good Information</h3>

                            <!--- Machine Part Number --->
                            <div class="mdl-grid">
                                <div class="mdl-cell mdl-cell--6-col mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                                    <!--- Input Machine Part Number --->
                                    <input class="mdl-textfield__input" type="text" id="machinePN" value="Modelo" runat="server"/>
                                    <label class="mdl-textfield__label" for="firstName">Modelo Maquina</label>
                                </div>

                                <!--- Machine Serial Number --->
                                <div class="mdl-cell mdl-cell--6-col mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                                    <!--- machine Serial Number --->
                                    <input class="mdl-textfield__input" type="text" id="machineSN" value="ZLN" runat="server" />
                                    <label class="mdl-textfield__label" for="secondName">Serie Maquina</label>
                                </div>
                            </div>
                            <!--- Separador Seccion cold plate --->
                            <h3>Informacion Cold Plate</h3>

                            <div class="mdl-grid">
                                <div class="mdl-cell mdl-cell--6-col mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                                    <!--- Input ColdPlate Serial --->
                                    <input class="mdl-textfield__input" type="text" id="coldplateSN" value="0112345" runat="server" />
                                    <label class="mdl-textfield__label" for="firstName">Serie Cold Plate</label>
                                </div>
                            </div>

                            <!--- Separador Request Information --->
                        <div class="form__article">
                            <h3>Informacion Solicitanten</h3>
                            <div class="mdl-grid">
                                <div class="mdl-cell mdl-cell--6-col mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                                    <!--- Input Supervisor --->
                                    <input class="mdl-textfield__input" type="text" value="" id="supervisor" disabled runat="server" />
                                    <label class="mdl-textfield__label" for="company">Supervisor</label>
                                </div>
                                
                           
                                <div class="mdl-cell mdl-cell--6-col mdl-textfield mdl-js-textfield mdl-textfield--floating-label getmdl-select">
                                    <!--- Drop Box Seleccionar Area --->
                                   
                                    <asp:DropDownList id="area" runat="server" class="mdl-textfield__input">
                                         
                                          
                                    </asp:DropDownList>
                                    
                                </div>
                        </div>

                           
                       <!--- Separador Seccion Details --->
                        <div class="form__article employer-form__general_skills">
                            <h3>Detalles</h3>
                            <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                                <!--- Input Details --->
                                <textarea class="mdl-textfield__input" type="text" rows="3" id="descripcion" runat="server"></textarea>
                                <label class="mdl-textfield__label" for="description">Describa los problemas que presenta el Cold Plate</label>
                            </div>
                        </div>
                       
                            <div class="form__action">
                            <!--- Boton Submit de la forma --->
                            <asp:Button ID="submit" class="mdl-button mdl-js-button mdl-button--raised color--light-blue" runat="server" OnClick="solicitarRetrabajo" Text="SOLICITAR" />
                          </div>
                    </form>
                </div>
            </div>
</asp:Content>
