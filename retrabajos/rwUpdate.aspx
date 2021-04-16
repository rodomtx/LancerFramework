<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rwUpdate.aspx.cs" Inherits="Templeate_LIN.retrabajos.rwUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="mdl-card mdl-shadow--2dp employer-form" action="#">
        
        <div id="avisos" runat="server"></div>
        <div class="mdl-card__title" >
            <!--- Titulo Subtitulo de la forma --->
           
            <h2 id="titulo" runat="server"></h2>
                   <div class="mdl-card__subtitle">Por favor actualiza la informacion</div>
                </div>
            
                <div class="mdl-card__supporting-text">
                    <form action="#" class="form" runat="server">
                        <div class="form__article">
                        <!--- Separador Seccion Finish Goos --->
                            <h3 id="tarea" runat="server"></h3>

                            <!--- Machine Part Number --->
                            <div class="mdl-grid">
                                <div class="mdl-cell mdl-cell--6-col mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                                    <!--- Input Machine Part Number --->
                                    <input class="mdl-textfield__input" type="text" id="comentarios" value="Comentarios" runat="server"/>
                                    <label class="mdl-textfield__label" >Comentarios</label>
                                </div>

                                
                            
                          </div>
                            <div class="form__action">
                            <!--- Boton Submit de la forma --->
                            <asp:Button ID="submit" class="mdl-button mdl-js-button mdl-button--raised color--light-blue" runat="server" OnClick="actualizarRW" Text="Guardar" />
                    </form>
                </div>
            </div>
</asp:Content>
