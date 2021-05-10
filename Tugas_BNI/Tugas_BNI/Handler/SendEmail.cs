using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace API.Handler
{
    public class SendEmail
    {
        public void SendRegister(string email, string fullname, string Password)
        {
            var time24 = DateTime.Now.ToString("HH:mm:ss");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("linkmuhammadreza@gmail.com", "muhammadreza098"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
                UseDefaultCredentials = false
            };
            NetworkCredential nc = new NetworkCredential("linkmuhammadreza@gmail.com", "muhammadreza098");
            smtp.Credentials = nc;
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("linkmuhammadreza@gmail.com", "Register");
            mailMessage.To.Add(new MailAddress(email));
            mailMessage.Subject = "Register " + time24;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body =

                          "<body style = 'width:100%;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>" +
                    "<div  style = 'background-color:#FAFAFA'>" +
                        "<table  width = '100%' cellspacing = '0' cellpadding = '0' style = 'border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top'>" +
                            "<tr style = 'border-collapse:collapse' >" +
                                " <td valign = 'top' style = 'padding:0;Margin:0' >" +
                                    "<table cellpadding = '0' cellspacing = '0'  align = 'center' style = 'border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top'>" +
                                        "<tr style = 'border-collapse:collapse'>" +
                                            "<td  align = 'center' style = 'padding:0;Margin:0'>" +
                                                "<table  style = 'border-collapse:collapse;border-spacing:0px;background-color:#d8dde5;width:600px' cellspacing = '0' cellpadding = '0' bgcolor = '#d8dde5' align = 'center'>" +
                                                    "<tr style = 'border-collapse:collapse'>" +
                                                         "<td style = 'Margin:0;padding-top:20px;padding-bottom:20px;padding-left:20px;padding-right:20px;background-color:#d8dde5' bgcolor = '#d8dde5' align = 'left'>" +
                                                  "<table cellspacing = '0' cellpadding = '0' width = '100%' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                     "<tr style = 'border-collapse:collapse'>" +
                                                        "<td align = 'left' style = 'padding:0;Margin:0;width:560px'>" +
                                                  "<table width = '100%' cellspacing = '0' cellpadding = '0' role = 'presentation' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                      "<tr style = 'border-collapse:collapse'>" +
                                                        "<td align = 'center' style = 'padding:0;Margin:0;font-size:0px' ><img  src = 'https://peiprq.stripocdn.email/content/guids/CABINET_1c539189dffd3317866123e9e166a198/images/1101620612070875.png'style = 'display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic' height = '121'/>" +
                                                        "</td>" +
                                                        "</tr>" +
                                                        "</table>" +
                                                        "</td>" +
                                                        "</tr>" +
                                                        "</table>" +
                                                        "</td>" +
                                                        "</tr>" +
                                                        "</table>" +
                                                        "</td>" +
                                                        "</tr>" +
                                                        "</table>" +


                              "<table  cellspacing = '0' cellpadding = '0' align = 'center' style = 'border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%'>" +
                                "<tr style = 'border-collapse:collapse'>" +
                                    "<td style = 'padding:0;Margin:0;background-color:#FAFAFA' bgcolor = '#fafafa' align = 'center'>" +
                                         "<table  style = 'border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px' cellspacing = '0' cellpadding = '0' bgcolor = '#ffffff' align = 'center'>" +
                                              "<tr style = 'border-collapse:collapse'>" +
                                                  "<td style = 'padding:0;Margin:0;padding-left:20px;padding-right:20px;padding-top:40px;background-color:transparent;background-position:left top' bgcolor = 'transparent' align = 'left'>" +
                                                      "<table width = '100%' cellspacing = '0' cellpadding = '0' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                         "<tr style = 'border-collapse:collapse'>" +
                                                            "<td valign = 'top' align = 'center' style = 'padding:0;Margin:0;width:560px'>" +
                                                            "<table style = 'border-collapse:collapse;border-spacing:0px;background-position:left top' width = '100%' cellspacing = '0' cellpadding = '0' role = 'presentation'>" +

                                                                        "<tr style = 'border-collapse:collapse' >" +
                                                                           "<td align = 'left' style = 'padding:0;Margin:0;padding-left:40px;padding-right:40px'><h4 style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px;text-align:center'>HI, " + fullname + "</h4>" +
                                                                           "</td></tr>" +
                                                                           "<td align = 'left' style = 'padding:0;Margin:0;padding-left:40px;padding-right:40px'><h4 style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px;text-align:center'>Selamat kamu berhasil daftar, berikut data kamu : </h4>" +
                                                                           "</td></tr>" +
                                                                             "<table style = 'margin-left:36px; '>" +
                                                                                  
                                                                                  "<tr>" +
                                                                                  "<td><h4>Nama</h4></td>" +
                                                                                  "<td><h4>: </h></td>" +
                                                                                  "<td><h4>" + fullname + "</h4></td>" +
                                                                                  "</tr>" +
                                                                                 

                                                                                  "<tr>" +
                                                                                  "<td><h4>Password</h4></td>" +
                                                                                  "<td><h4>: </h></td>" +
                                                                                  "<td><h4>" + Password + "</h4></td>" +
                                                                                  "</tr>" +

                                                                                  


                                                                                  "</table>" +

                                                                                   "<tr style = 'border-collapse:collapse' >" +
                                                                           "<td align = 'left' style = 'padding:0;Margin:0;padding-left:40px;padding-right:40px'><h4 style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px;text-align:center'>Silahkan login dengan email dan password yang tertera di atas. Terima kasih atas perhatiannya</h4>" +
                                                                           "</td></tr>" +

                                                                           "<tr style = 'border-collapse:collapse' >" +
                                                                           "<td align = 'left' style = 'padding:0;Margin:0;padding-left:40px;padding-right:40px'><h4 style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px;text-align:center'>Admin</h4>" +
                                                                           "</td></tr>" +
                                                                                "<br>" +
                                                                                "<br>" +

                                                                                "</table>" +
                                                                                "</td>" +
                                                                                "</tr>" +
                                                                                "</table>" +
                                                                                "</td>" +
                                                                                "</tr>" +
                                                                                "</table>" +
                                                                                "</td>" +
                                                                                "</tr>" +
                                                                                "</table>" +


                               "<table  cellspacing = '0' cellpadding = '0' align = 'center' style = 'border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top'>" +
                               "<tr style = 'border-collapse:collapse'>" +
                                    "<td style = 'padding:0;Margin:0;background-color:#FAFAFA' bgcolor = '#fafafa' align = 'center'>" +
                                             "<table  cellspacing = '0' cellpadding = '0' bgcolor = '#ffffff' align = 'center' style = 'border-collapse:collapse;border-spacing:0px;background-color:transparent;width:600px'>" +
                                                          "<tr style = 'border-collapse:collapse' >" +
                                                               "<td style = 'Margin:0;padding-top:10px;padding-left:20px;padding-right:20px;padding-bottom:30px;background-color:#467BA5' bgcolor = '#467ba5' align = 'left'>" +
                                                                        "<table width = '100%' cellspacing = '0' cellpadding = '0' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                                                   "<tr style = 'border-collapse:collapse' >" +
                                                                                        "<td valign = 'top' align = 'center' style = 'padding:0;Margin:0;width:560px' >" +
                                                                                            "<table width = '100%' cellspacing = '0' cellpadding = '0' role = 'presentation' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                                                                "<tr style = 'border-collapse:collapse' >" +
                                                                                                    "<td align = 'left' style = 'padding:0;Margin:0;padding-top:5px;padding-bottom:5px' ><h2 style = 'Margin:0;line-height:19px;font-family:arial, 'helvetica neue', helvetica, sans-serif;font-size:16px;font-style:normal;font-weight:normal;color:#FFFFFF'><br/></h2></td >" +
                                                                                                       "</tr><tr style = 'border - collapse:collapse' >" +

                                                                                        "<td align = 'center' style = 'padding:0;Margin:0;padding-bottom:5px; color:#ffffff'  ><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:21px;color:#FFFFFF;font-size:14px'><b> PT.Mitra Integrasi Informatika</b> &nbsp;| member of METRODATA</p><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:21px;color:#FFFFFF;font-size:14px'> APL Tower 18 th Fl., Jl. Letjend.S.Parman kav. 28, Jakarta 11470 </p><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:21px;color:#FFFFFF;font-size:14px'> Phone : ;<a href = 'callto:021-29345777' style = '-webkit-text-size-adjust:none;-ms-text-size-adjust:none;text-decoration:none;color:#333333;font-size:14px'> 021 - 29345777 </a> &nbsp; ext 3307 | Fax : <a href = 'callto:(62-21) 29345 700' style = '-webkit-text-size-adjust:none;-ms-text-size-adjust:none;text-decoration:none;color:#333333;font-size:14px'> (62 - 21) 29345 700 </a> &nbsp;| Website <a target = '_blank' href = 'http://www.mii.co.id/' style = '-webkit-text-size-adjust:none;-ms-text-size-adjust:none;text-decoration:none;color:#333333;font-size:14px'> www.mii.co.id </a></p><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:21px;color:#FFFFFF;font-size:14px'><a target = '_blank' style = '-webkit-text-size-adjust:none;-ms-text-size-adjust:none;text-decoration:none;color:#FFFFFF;font-size:14px' href = '' ></a></p></td>" +
                                                                                                                           "</tr>" +
                                                                                                                           "</table>" +
                                                                                                                           "</td>" +
                                                                                                                           " </tr>" +
                                                                                                                           "</table>" +
                                                                                                                           "</td>" +
                                                                                                                           "</tr>" +
                                                                                                                           "</table>" +
                                                                                                                           "</td>" +
                                                                                                                           "</tr>" +
                                                                                                                           "</table>" +
                                                                                                                           "</td>" +
                                                                                                                           "</tr> " +
                                                                                                                           "</table>" +
                                                                                                                           "</div>" +
                                                                                                                           "</body>";

            smtp.Send(mailMessage);
        }

        public void SendForgotPassword(string name, string resetCode, string email)
        {
            var time24 = DateTime.Now.ToString("HH:mm:ss");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("linkmuhammadreza@gmail.com", "muhammadreza098"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
                UseDefaultCredentials = false
            };
            NetworkCredential nc = new NetworkCredential("linkmuhammadreza@gmail.com", "muhammadreza098");
            smtp.Credentials = nc;
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("linkmuhammadreza@gmail.com", "Reset Password");
            mailMessage.To.Add(new MailAddress(email));
            mailMessage.Subject = "Reset Password " + time24;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body =
                "<body style = 'width:100%;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>" +
                    "<div  style = 'background-color:#FAFAFA'>" +
                        "<table  width = '100%' cellspacing = '0' cellpadding = '0' style = 'border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top'>" +
                            "<tr style = 'border-collapse:collapse' >" +
                                " <td valign = 'top' style = 'padding:0;Margin:0' >" +
                                    "<table cellpadding = '0' cellspacing = '0'  align = 'center' style = 'border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top'>" +
                                        "<tr style = 'border-collapse:collapse'>" +
                                            "<td  align = 'center' style = 'padding:0;Margin:0'>" +
                                                "<table  style = 'border-collapse:collapse;border-spacing:0px;background-color:#d8dde5;width:600px' cellspacing = '0' cellpadding = '0' bgcolor = '#d8dde5' align = 'center'>" +
                                                    "<tr style = 'border-collapse:collapse'>" +
                                                         "<td style = 'Margin:0;padding-top:20px;padding-bottom:20px;padding-left:20px;padding-right:20px;background-color:#d8dde53' bgcolor = '#d8dde5' align = 'left'>" +
                                                  "<table cellspacing = '0' cellpadding = '0' width = '100%' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                     "<tr style = 'border-collapse:collapse'>" +
                                                        "<td align = 'left' style = 'padding:0;Margin:0;width:560px'>" +
                                                  "<table width = '100%' cellspacing = '0' cellpadding = '0' role = 'presentation' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                      "<tr style = 'border-collapse:collapse'>" +
                                                        "<td align = 'center' style = 'padding:0;Margin:0;font-size:0px' ><img  src = 'https://peiprq.stripocdn.email/content/guids/CABINET_1c539189dffd3317866123e9e166a198/images/1101620612070875.png'style = 'display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic' height = '121'/>" +
                                                        "</td>" +
                                                        "</tr>" +
                                                        "</table>" +
                                                        "</td>" +
                                                        "</tr>" +
                                                        "</table>" +
                                                        "</td>" +
                                                        "</tr>" +
                                                        "</table>" +
                                                        "</td>" +
                                                        "</tr>" +
                                                        "</table>" +


                              "<table  cellspacing = '0' cellpadding = '0' align = 'center' style = 'border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%'>" +
                                "<tr style = 'border-collapse:collapse'>" +
                                    "<td style = 'padding:0;Margin:0;background-color:#FAFAFA' bgcolor = '#fafafa' align = 'center'>" +
                                         "<table  style = 'border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px' cellspacing = '0' cellpadding = '0' bgcolor = '#ffffff' align = 'center'>" +
                                              "<tr style = 'border-collapse:collapse'>" +
                                                  "<td style = 'padding:0;Margin:0;padding-left:20px;padding-right:20px;padding-top:40px;background-color:transparent;background-position:left top' bgcolor = 'transparent' align = 'left'>" +
                                                      "<table width = '100%' cellspacing = '0' cellpadding = '0' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                         "<tr style = 'border-collapse:collapse'>" +
                                                            "<td valign = 'top' align = 'center' style = 'padding:0;Margin:0;width:560px'>" +
                                                            "<table style = 'border-collapse:collapse;border-spacing:0px;background-position:left top' width = '100%' cellspacing = '0' cellpadding = '0' role = 'presentation'>" +
                                                               "<tr style = 'border-collapse:collapse'>" +
                                                                "<td align = 'center' style = 'padding:0;Margin:0;padding-top:5px;padding-bottom:5px;font-size:0'><img src = 'https://peiprq.stripocdn.email/content/guids/CABINET_dd354a98a803b60e2f0411e893c82f56/images/23891556799905703.png'  style = 'display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic' width = '175'/>" +
                                                                "</td ></tr >" +
                                                                  "<tr style = 'border-collapse:collapse'>" +
                                                                  "<td align = 'center' style = 'padding:0;Margin:0;padding-top:15px;padding-bottom:15px'><h1 style = 'Margin:0;line-height:24px;font-family:arial, 'helvetica neue', helvetica, sans-serif;font-size:20px;font-style:normal;font-weight:normal;color:#333333'><strong> FORGOT YOUR </strong></h1><h1 style = 'Margin:0;line-height:24px;font-family:arial, 'helvetica neue', helvetica, sans-serif;font-size:20px;font-style:normal;font-weight:normal;color:#333333'><strong> &nbsp; PASSWORD ?</strong></h1></td >" +
                                                                      "</tr>" +
                                                                        "<tr style = 'border-collapse:collapse' >" +
                                                                           "<td align = 'center' style = 'padding:0;Margin:0;padding-left:40px;padding-right:40px'><h3 style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px;text-align:center'> HI, " + name + "</h3>" +
                                                                           "</td></tr>" +
                                                                             "<tr style = 'border-collapse:collapse'>" +
                                                                                "<td align = 'center' style = 'padding:0;Margin:0;padding-right:35px;padding-left:40px'><h3 style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:24px;color:#666666;font-size:16px;text-align:center'> This is new password for your account. " + resetCode + "</h3>" +

                                                                                "<br>" +
                                                                                "<br>" +
                                                                                "</td>" +
                                                                                "</tr>" +
                                                                                "</table>" +
                                                                                "</td>" +
                                                                                "</tr>" +
                                                                                "</table>" +
                                                                                "</td>" +
                                                                                "</tr>" +
                                                                                "</table>" +
                                                                                "</td>" +
                                                                                "</tr>" +
                                                                                "</table>" +


                               "<table  cellspacing = '0' cellpadding = '0' align = 'center' style = 'border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%;background-color:transparent;background-repeat:repeat;background-position:center top'>" +
                               "<tr style = 'border-collapse:collapse'>" +
                                    "<td style = 'padding:0;Margin:0;background-color:#FAFAFA' bgcolor = '#fafafa' align = 'center'>" +
                                             "<table  cellspacing = '0' cellpadding = '0' bgcolor = '#ffffff' align = 'center' style = 'border-collapse:collapse;border-spacing:0px;background-color:transparent;width:600px'>" +
                                                          "<tr style = 'border-collapse:collapse' >" +
                                                               "<td style = 'Margin:0;padding-top:10px;padding-left:20px;padding-right:20px;padding-bottom:30px;background-color:#467BA5' bgcolor = '#467ba5' align = 'left'>" +
                                                                        "<table width = '100%' cellspacing = '0' cellpadding = '0' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                                                   "<tr style = 'border-collapse:collapse' >" +
                                                                                        "<td valign = 'top' align = 'center' style = 'padding:0;Margin:0;width:560px' >" +
                                                                                            "<table width = '100%' cellspacing = '0' cellpadding = '0' role = 'presentation' style = 'border-collapse:collapse;border-spacing:0px'>" +
                                                                                                "<tr style = 'border-collapse:collapse' >" +
                                                                                                    "<td align = 'left' style = 'padding:0;Margin:0;padding-top:5px;padding-bottom:5px' ><h2 style = 'Margin:0;line-height:19px;font-family:arial, 'helvetica neue', helvetica, sans-serif;font-size:16px;font-style:normal;font-weight:normal;color:#FFFFFF'><br/></h2></td >" +
                                                                                                       "</tr><tr style = 'border - collapse:collapse' >" +

                                                                                        "<td align = 'center' style = 'padding:0;Margin:0;padding-bottom:5px; color:#ffffff'  ><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:21px;color:#FFFFFF;font-size:14px'><b> PT.Mitra Integrasi Informatika</b> &nbsp;| member of METRODATA</p><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:21px;color:#FFFFFF;font-size:14px'> APL Tower 18 th Fl., Jl. Letjend.S.Parman kav. 28, Jakarta 11470 </p><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:21px;color:#FFFFFF;font-size:14px'> Phone : ;<a href = 'callto:021-29345777' style = '-webkit-text-size-adjust:none;-ms-text-size-adjust:none;text-decoration:none;color:#333333;font-size:14px'> 021 - 29345777 </a> &nbsp; ext 3307 | Fax : <a href = 'callto:(62-21) 29345 700' style = '-webkit-text-size-adjust:none;-ms-text-size-adjust:none;text-decoration:none;color:#333333;font-size:14px'> (62 - 21) 29345 700 </a> &nbsp;| Website <a target = '_blank' href = 'http://www.mii.co.id/' style = '-webkit-text-size-adjust:none;-ms-text-size-adjust:none;text-decoration:none;color:#333333;font-size:14px'> www.mii.co.id </a></p><p style = 'Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;font-family:helvetica, 'helvetica neue', arial, verdana, sans-serif;line-height:21px;color:#FFFFFF;font-size:14px'><a target = '_blank' style = '-webkit-text-size-adjust:none;-ms-text-size-adjust:none;text-decoration:none;color:#FFFFFF;font-size:14px' href = '' ></a></p></td>" +
                                                                                                                           "</tr>" +
                                                                                                                           "</table>" +
                                                                                                                           "</td>" +
                                                                                                                           " </tr>" +
                                                                                                                           "</table>" +
                                                                                                                           "</td>" +
                                                                                                                           "</tr>" +
                                                                                                                           "</table>" +
                                                                                                                           "</td>" +
                                                                                                                           "</tr>" +
                                                                                                                           "</table>" +
                                                                                                                           "</td>" +
                                                                                                                           "</tr> " +
                                                                                                                           "</table>" +
                                                                                                                           "</div>" +
                                                                                                                           "</body>";


            smtp.Send(mailMessage);
        }
    }
}
