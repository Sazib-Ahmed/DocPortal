using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using static BLL.APIs.APIUsed;
using System.Net.Mail;
using System.Net;
using Google.Rpc;


namespace BLL.APIs
{
    internal class APIUsed
    {
        public static string Translate(string input, string from, string to)
        {
            var client = TranslationClient.CreateFromApiKey("AIzaSyCJsMATXnoBIvjVLb3D3A1uliooDpnju_E");
            var response = client.TranslateText(input, to, from);

            if (!string.IsNullOrEmpty(response.TranslatedText))
            {
                return response.TranslatedText;
            }
            else
            {
                return "Translation failed";
            }
        }


        public static void SendEmail(string emailTo, string subject, string emailMessage)
        {
            try
            {
                string fromMail = "sazibahmed9@gmail.com"; 
                string fromPassword = "kpmfyuzgeliswhyc";

                MailMessage message = new MailMessage
                {
                    From = new MailAddress(fromMail),
                    Subject = subject
                };
                message.To.Add(new MailAddress(emailTo));

                
                string formattedMessage = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <style>
                    body {{
                        font-family: 'Arial', sans-serif;
                        padding: 20px;
                        line-height: 1.6;
                    }}
                    .container {{
                        border: 1px solid #ccc;
                        padding: 20px;
                        border-radius: 5px;
                        background-color: #f9f9f9;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    {emailMessage.Replace("\n", "<br/>")}
                </div>
            </body>
            </html>";

                message.Body = formattedMessage;
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }

    }
}