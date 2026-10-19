using SimpleFactory.Interface;
using System;

namespace SimpleFactory.Strategies
{
    public class SMSNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("SMS enviado");
        }
    }
}