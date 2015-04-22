using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Notifications.Config;

namespace MonitoringAgent.Notifications.Services
{
    /// <summary>
    /// Service for send notifications by e-mail
    /// </summary>
    internal sealed class MailNotificationSendService : IMailNotificationSendService
    {
        /// <summary>
        /// Send e-mail notification to list of subscribers
        /// </summary>
        /// <param name="notification">Notification</param>
        /// <param name="subscribers">List of subscribers</param>
        public void SendNotification(MasterDataNotifications notification, IList<MasterDataSubscribers> subscribers)
        {
            SendMailToSubscribers(notification.Subject, notification.Message, subscribers, false);
        }

        /// <summary>
        /// Send report about erros in log files to all subscribers
        /// </summary>
        /// <param name="subscribers">Subscribers</param>
        /// <param name="report">Html report</param>
        public void SendErrorReport(IList<MasterDataSubscribers> subscribers, string report)
        {
            SendMailToSubscribers("Error report", report, subscribers, true);
        }

        private void SendMailToSubscribers(string subject, string body, IList<MasterDataSubscribers> subscribers, bool isBodyHtml)
        {
            foreach (var subscriber in subscribers)
            {
                SendMail(NotificationServerConfigSection.Instance.SmtpServer,
                    NotificationServerConfigSection.Instance.SmtpServerAccountName,
                    NotificationServerConfigSection.Instance.SmtpServerAccountPassword,
                    subscriber.Email,
                    subject,
                    body,
                    NotificationServerConfigSection.Instance.SmtpServerPort,
                    NotificationServerConfigSection.Instance.EnableSsl,
                    NotificationServerConfigSection.Instance.SmtpDeliveryMethod, isBodyHtml);
            }
        }

        private void SendMail(string smtpServer, string @from, string password, string mailto, string caption, string message, int port, bool enableSsl, SmtpDeliveryMethod smtpDeliveryMethod, bool isBodyHtml)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                mail.IsBodyHtml = isBodyHtml;
                SmtpClient client = new SmtpClient
                {
                    Host = smtpServer,
                    Port = port,
                    EnableSsl = enableSsl,
                    Credentials = new NetworkCredential(@from.Split('@')[0], password),
                    DeliveryMethod = smtpDeliveryMethod
                };
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                //throw new Exception("Mail.Send: " + e.Message);
            }
        }
    }
}
