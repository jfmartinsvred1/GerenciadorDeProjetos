using Gerenciador.Models;
using System.Net;
using System.Net.Mail;

namespace Gerenciador.Services
{
    public static class Email
    {

        public static string SendEmailConfirmation(string email)
        {
            string code = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);
            var validator = new ValidationEmail();
            validator.Email = email;
            validator.Code = code;


            MailMessage emailMessage = new MailMessage();
            try
            {
                var smtpClient= new SmtpClient("smtp.office365.com", 587);
                smtpClient.EnableSsl = true;

                smtpClient.Timeout = 5000;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials= new NetworkCredential("TestApiJfmartins@outlook.com", "Apiemail123!");
                emailMessage.From = new MailAddress("TestApiJfmartins@outlook.com", "JJSOFTWARE");
                emailMessage.Body = $"Confirme seu email na nossa aplicação <br> Código: {code}";
                emailMessage.Subject = "Confirmação de email";
                emailMessage.IsBodyHtml = true;
                emailMessage.Priority = MailPriority.Normal;
                emailMessage.To.Add(email);

                smtpClient.Send(emailMessage);
                smtpClient.Dispose();

                return code;

            }
            catch(Exception ex) 
            {
                return "";
            }
        }

    }
}
