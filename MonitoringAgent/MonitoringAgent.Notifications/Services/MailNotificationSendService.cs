using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
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
            foreach (var subscriber in subscribers)
            {
                SendMail(NotificationServerConfigSection.Instance.SmtpServer,
                    NotificationServerConfigSection.Instance.SmtpServerAccountName,
                    NotificationServerConfigSection.Instance.SmtpServerAccountPassword,
                    subscriber.Email,
                    notification.Subject,
                    notification.Message);
            }
        }

        private void SendMail(string smtpServer, string from, string password, string mailto, string caption, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                SmtpClient client = new SmtpClient
                {
                    Host = smtpServer,
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(@from.Split('@')[0], password),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }
    }
}
