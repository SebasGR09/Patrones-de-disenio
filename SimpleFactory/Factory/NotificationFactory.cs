using SimpleFactory.Interface;
using SimpleFactory.Strategies;
using System;

namespace SimpleFactory.Factory
{
    public class NotificationFactory
    {
        public INotification Create(string type)
        {
            if(type == "email")
            {
                return new EmailNotification();
            }
            else if(type == "sms")
            {
                return new SMSNotification();
            }

            throw new ArgumentException("El tipo de notificacion no es valido", nameof(type));
        }

    }
}