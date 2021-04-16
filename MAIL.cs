using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;

namespace Templeate_LIN
{
    public class MAIL
    {



       public  void notificacionTarea(string _dirigidoA,string _textoTarea , string _liga)
        {
            SmtpClient smtp_server = new SmtpClient();
            MailMessage email = new MailMessage();
            
            email.From = new MailAddress("noreply@lancerworldwide.com");

            email.To.Add(_dirigidoA);
            email.CC.Add("rodolfo.martinez@lancerworldwide.com");
            email.Subject = "Lancer Framework - Tarea Asignada";
            email.IsBodyHtml = true;
            email.Body = this.cuerpoCorreoTarea(_dirigidoA, _textoTarea , _liga);
            smtp_server.Send(email);


        
        }

        /*
         Subject
         Link (rwID)
         A que grupo va dirigido o las direcciones de correo?
         Accion
         
         */


        string cuerpoCorreoTarea(string dirigidoA, string textoTarea, string liga)
        {
            StringBuilder ans = new StringBuilder();
            ans.Append("<!DOCTYPE html>");
            ans.Append("<html>");
            ans.Append("<head>");
            ans.Append("    <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>");
            ans.Append("    <meta name='Generator' content='Microsoft Word 14 (filtered)'>");
            ans.Append("    <title> Una tarea fue asignada </title>");
            ans.Append("    <style>");
            ans.Append("        body {");
            ans.Append("            font-family: 'Segoe UI';");
            ans.Append("        }");
            ans.Append("    </style>");
            ans.Append("</head>");
            ans.Append("<body style='background-color: silver'>");
            ans.Append("    <div>");
            ans.Append("        <center>");
            ans.Append("            <table style='width: 705px; height: 1000px; border: solid 0.5px #e1dcdc; background-color: white'>");
            ans.Append("               ");
            ans.Append("                <tr>");
            ans.Append("                    <td style='height:1px; width:100%; margin:0px 0px 0px 0px;'>");
            ans.Append("                        <br>");
            ans.Append("                        <center>");
            ans.Append("                            <p style='font-family: 'Segoe UI'; font-size:28px; font-weight:300; color:#333333; text-align:center; border-bottom: 1px solid #F5F5F5; padding-bottom: 15px'>" + dirigidoA +  ", es necesaria tu intervencion para continuar el proceso de retrabajo</p>");
            ans.Append("                        </center>");
            ans.Append("                        <br>");
            ans.Append("                    </td>");
            ans.Append("                </tr>");
            ans.Append("                <tr>");
            ans.Append("                    <td>");
            ans.Append("                        <center>");
            ans.Append("                            <p style='font-family: 'Segoe UI'; font-size:25px; font-weight:300; color: #333333;'>"+textoTarea+"</p>");
            ans.Append("                            <!---<p style='font-family: 'Segoe UI'; font-size:12px; font-weight:300; color: #333333;'></p>-->");
            ans.Append("                            <br>");
            ans.Append("                        </center>");
            ans.Append("                    </td>");
            ans.Append("                </tr>");
            ans.Append("                <tr>");
            ans.Append("                    <td align='center' style='padding: 10px 0 10px 0;'>");
            ans.Append("                        <table border='0' cellpadding='0' cellspacing='0' width='100%' style='padding-left:18px;'>");
            ans.Append("                            <tr>");
            ans.Append("                                <td>");
            ans.Append("                                    <table border='0' cellspacing='0' cellpadding='0' align='center'>");
            ans.Append("                                        <tr>");
            ans.Append("                                            <td style='-webkit-border-radius: 5px; -moz-border-radius: 5px; border-radius: 5px;padding-top:5px; padding-right:5px; padding-bottom:5px; padding-left:5px;' align='center' bgcolor='#1380ec'>");
            ans.Append("                                                <span>");
            ans.Append("                                                    <a href='http:\\192.168.60.222:82/retrabajos/rwSeguimiento.aspx?rwID=" + liga + "'  style='font-size: 15px; font-family: 'Segoe UI'; font-weight: 600; color: #070707; text-decoration: none; -webkit-border-radius: 5px; -moz-border-radius: 5px; border-radius: 5px; padding-top:5px; padding-right:5px; padding-bottom:5px; padding-left:5px; border: 1px solid #1380ec; display: inline-block;'>&nbsp;&nbsp; Continuar &nbsp;&nbsp;</a>");
            ans.Append("                                                </span>");
            ans.Append("                                            </td>");
            ans.Append("                                          ");
            ans.Append("                                        </tr>");
            ans.Append("                                    </table>");
            ans.Append("                                </td>");
            ans.Append("                            </tr>");
            ans.Append("                        </table>");
            ans.Append("                    </td>");
            ans.Append("                </tr>");
            ans.Append("                <tr>");
            ans.Append("                    <td style='margin:0px 15px 0px 15px; width: 80%'>");
            ans.Append("                        <center>");
            ans.Append("                            <br>");
            ans.Append("                            <p style='height:80px; width:500px; font-family: 'Segoe UI';font-size: 16px; font-weight: 300; line-height: 1.25; text-align: left; color: #333333;'>");
            ans.Append("                               Informacion Adicional ");
            ans.Append("                            </p><br>");
            ans.Append("                        </center>");
            ans.Append("                    </td>");
            ans.Append("                </tr>");
            ans.Append("                 </table>");
            ans.Append("                    </td>");
            ans.Append("                </tr>");
            ans.Append("              ");
            ans.Append("              ");
            ans.Append("            </table>");
            ans.Append("        </center>");
            ans.Append("    </div>");
            ans.Append("</body>");
            ans.Append("</html>");
            return ans.ToString();
        }
    }
}