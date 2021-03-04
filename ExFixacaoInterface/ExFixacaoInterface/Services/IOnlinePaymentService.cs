using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacaoInterface.Services
{
    interface IOnlinePaymentService
    {

        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
