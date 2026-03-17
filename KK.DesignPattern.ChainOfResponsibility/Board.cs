namespace KK.DesignPattern.ChainOfResponsibility
{
    internal class Board : Approver
    {
        public override void ProcessRequest(int amount)
        {
            var decision = new Random().Next(0, 2);
            Console.WriteLine(
                decision == 1
                    ? $"Request Approved by Board,    amount {amount}"
                    : $"Request Rejected by Board,    amount {amount}");

            return;
        }
    }
}
