using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    //Context Strategy
    //Depend on Interface
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;
        private IWorkflowStrategy _workflowStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy, IWorkflowStrategy workflowStrategy)
        {
            _paymentStrategy = paymentStrategy;
            _workflowStrategy = workflowStrategy;
        }

        public void ChangeStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ExecutePayment(decimal amount)
        {
            _paymentStrategy.Pay(amount);
           // _workflowStrategy.

        }
        public void WorkFlowchange(IWorkflowStrategy workflow)
        {
            _workflowStrategy= workflow;

        }
    }

}
