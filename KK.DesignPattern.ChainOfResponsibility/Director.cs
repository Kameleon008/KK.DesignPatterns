namespace KK.DesignPattern.ChainOfResponsibility
{
    internal class Director : Approver
    {
        private readonly int _approvalThreshold = 5000;

        public override void ProcessRequest(int amount)
        {
            if (amount < _approvalThreshold)
            {
                var decision = new Random().Next(0, 2);
                Console.WriteLine(
                    decision == 1
                        ? $"Request Approved by Director, amount {amount}"
                        : $"Request Rejected by Director, amount {amount}");

                return;
            }

            Console.WriteLine("Request exceeds approval threshold for Director");
            this.NextApprover.ProcessRequest(amount);
        }
    }
}
