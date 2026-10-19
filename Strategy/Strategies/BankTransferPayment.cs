using Strategy.Interface;
using System;

namespace Strategy.Strategies
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public string Pay(double amount)
        {
            return $"Pago de {amount} realizado con Transferencia bancaria";
        }
    }
}