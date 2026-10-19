using System;

namespace Strategy.Interface {
    public interface IPaymentStrategy
    {
        string Pay(double amount);
    }
}