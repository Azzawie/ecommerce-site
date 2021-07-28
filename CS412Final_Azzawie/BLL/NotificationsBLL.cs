using System;
using System.Net.Mail;
using System.Threading.Tasks;
using CS412Final_Azzawie.BLL.Interfaces;
using CS412Final_Azzawie.Reopsitories.Interfaces;
using CS412Final_Azzawie.Reopsitories;

namespace CS412Final_Azzawie.BLL
{
    public class NotificationsBLL : INotificationsBLL
    {
        private readonly IError _error;
        public NotificationsBLL()
        {
            _error = new Error();
        }
        public async Task SendEmail(string to, string subject, string body, string replyTo = "")
        {
            using (MailMessage message = new MailMessage())
            {
                message.To.Add(to.Trim());
                message.From = new MailAddress(message.From.Address, "Buy&Sell WebSite");
                message.Subject = subject;
                if (string.IsNullOrWhiteSpace(replyTo) == false)
                {
                    message.ReplyToList.Add(replyTo.Trim());
                }
                message.Body = body;
                message.IsBodyHtml = true;

                using (SmtpClient client = new SmtpClient())
                {
                    try
                    {
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        _error.Log(ex);
                    }
                }
            }
        }
    }
}