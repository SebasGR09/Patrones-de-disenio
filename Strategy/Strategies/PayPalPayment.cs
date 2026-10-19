using Strategy.Interface;
using System;

namespace Strategy.Strategies
{
    public class PayPalPayment : IPaymentStrategy
    {
        public string Pay(double amount)
        {
            return $"Pago de {amount} realizado con PayPal";
        }
    }
}