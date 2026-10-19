using SimpleFactory.Interface;
using System;

namespace SimpleFactory.Strategies
{
    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Email enviado");
        }
    }
}