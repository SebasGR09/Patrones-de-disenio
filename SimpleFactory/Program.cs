using SimpleFactory.Factory;
using SimpleFactory.Interface;
using System;

namespace SimpleFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory fabrica = new NotificationFactory();

            INotification sms = fabrica.Create("sms");
            INotification email = fabrica.Create("email");

            email.Send();
            sms.Send();




            //fabrica.Create("email").Send();
            //fabrica.Create("sms").Send();
            //fabrica.Create("error").Send();
        }
    }
}