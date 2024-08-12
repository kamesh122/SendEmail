using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SendGridEmail
    {
        public async Task SendGridEmailAsync()
        {
            string FromEmail = "kameswararao.velivela@gmail.com";

            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(FromEmail, "Kameswararao Velivela");
            var subject = "Hello Test Email";
            var to = new EmailAddress("Kamesh122@gmail.com", "Kamesh");
            var plainTextContent = "How cool an email!";
            var htmlContent = string.Empty;
            var pathToFile = "EmailTemplate.html";
            //using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
            //{
            //    htmlContent = SourceReader.ReadToEnd();
            //}
          
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            msg.HtmlContent= "Test Email Verification";

            var response = await client.SendEmailAsync(msg);
        }

        


    }
}
