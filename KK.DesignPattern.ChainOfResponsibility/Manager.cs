using System;
using System.Collections.Generic;
using System.Text;

namespace KK.DesignPattern.ChainOfResponsibility
{
    internal class Manager : Approver
    {
        private readonly int _approvalThreshold = 1000;

        public override void ProcessRequest(int amount)
        {
            if (amount < _approvalThreshold)
            {
                var decision = new Random().Next(0, 2);
                Console.WriteLine(
                    decision == 1
                        ? $"Request Approved by Manager,  amount {amount}"
                        : $"Request Rejected by Manager,  amount {amount}");

                return;
            }

            Console.WriteLine("Request exceeds approval threshold for Manager");
            this.NextApprover.ProcessRequest(amount);
        }
    }
}
