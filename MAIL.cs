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



       public  void enviar_correo()
        {
            SmtpClient smtp_server = new SmtpClient();
            MailMessage email = new MailMessage();
           /* smtp_server.Port = 587;
            smtp_server.EnableSsl = true;
            smtp_server.Host = "smtp.office365.com";
            smtp_server.Credentials = new System.Net.NetworkCredential("noreply@lancerworldwide.com", "Lancer@219");
           */
            
            email.From = new MailAddress("noreply@lancerworldwide.com");



           
            email.To.Add("rodolfo.martinez@lancercorp.com");
            email.CC.Add("rodolfo.martinez@lancerworldwide.com");
            email.Subject = "Test Mail LancerFramework";
            email.IsBodyHtml = true;
            email.Body = this.correoHtml();
            smtp_server.Send(email);

        }


        string correoHtml()
        {
            StringBuilder ans = new StringBuilder();
            ans.Append("<!DOCTYPE html>");
            ans.Append("<html>");
            ans.Append("<head>");
            ans.Append("    <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>");
            ans.Append("    <meta name='Generator' content='Microsoft Word 14 (filtered)'>");
            ans.Append("    <title></title>");
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
            ans.Append("                            <p style='font-family: 'Segoe UI'; font-size:28px; font-weight:300; color:#333333; text-align:center; border-bottom: 1px solid #F5F5F5; padding-bottom: 15px'>Rodolfo, se genero una solicitud de Retrabajo nueva</p>");
            ans.Append("                        </center>");
            ans.Append("                        <br>");
            ans.Append("                    </td>");
            ans.Append("                </tr>");
            ans.Append("                <tr>");
            ans.Append("                    <td>");
            ans.Append("                        <center>");
            ans.Append("                            <p style='font-family: 'Segoe UI'; font-size:25px; font-weight:300; color: #333333;'>Se necesita generar el Journal</p>");
            ans.Append("                            <!---<p style='font-family: 'Segoe UI'; font-size:12px; font-weight:300; color: #333333;'>Public group with 13 members</p>-->");
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
            ans.Append("                                                    <a href='/retrabajos/rwHospital.aspx'  style='font-size: 15px; font-family: 'Segoe UI'; font-weight: 600; color: #070707; text-decoration: none; -webkit-border-radius: 5px; -moz-border-radius: 5px; border-radius: 5px; padding-top:5px; padding-right:5px; padding-bottom:5px; padding-left:5px; border: 1px solid #1380ec; display: inline-block;'>&nbsp;&nbsp;<!--[if mso]>&nbsp;&nbsp;&nbsp;<![endif]-->Proceder<!--[if mso]>&nbsp;&nbsp;&nbsp;<![endif]-->&nbsp;&nbsp;</a>");
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
            ans.Append("                                Renew LMX_Back Shops before it expires on Thursday, January 7, 2021. If it isn't renewed, it will be deleted, along with all associated communications, files, calendar events, and tasks.");
            ans.Append("                                You received this email because you're an owner of the group.");
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