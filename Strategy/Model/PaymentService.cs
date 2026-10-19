using Strategy.Interface;
using System;

namespace Strategy.Model
{
    public class PaymentService
    {

        private readonly IPaymentStrategy _payment;

        public PaymentService(IPaymentStrategy payment) 
        {   
            this._payment = payment;
            
        }


        public string ProcessPayment(double amount)
        {
            return _payment.Pay(amount);
        }
    }
}