using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SendEmailWithGoogleSMTP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fromMail = "samplemail@gmail.com";  //Users mail from where the mail will be sent
            string fromPassword = "SampleSecurityKey";  //Security key got from the mail account of the user

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Test Mail";
            message.To.Add(new MailAddress("samplerecievemail@gmail.com")); //mail to recieve
            message.Body = "<html><body>" +
                           "We are excited to announce a new job opportunity.If you are looking for a challenging role, consider applying for the following position." +
                           "</body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);

            Console.WriteLine("Mail Sent");
            Console.ReadKey();
        }
    }
}

//rucq uugs dshs cmbx