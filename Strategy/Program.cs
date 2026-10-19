using Strategy.Interface;
using Strategy.Model;
using Strategy.Strategies;
using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Estrategias que tienen contrato con la interfaz
            IPaymentStrategy strategy_1 = new BankTransferPayment();
            IPaymentStrategy strategy_2 = new CreditCardPayment();
            IPaymentStrategy strategy_3 = new PayPalPayment();


            // Servicio de pagos que recibe la estrategias
            PaymentService pagos = new PaymentService(strategy_3);

            Console.WriteLine(pagos.ProcessPayment(1000));
        }
    }
}