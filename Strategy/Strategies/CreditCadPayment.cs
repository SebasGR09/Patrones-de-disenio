using Strategy.Interface;
using System;

namespace Strategy.Strategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public string Pay(double amount)
        {
            return $"Pago de {amount} realizado con tarjeta de credito";
        }
    }
}