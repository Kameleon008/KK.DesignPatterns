namespace KK.DesignPattern.ChainOfResponsibility
{
    public abstract class Approver : IApprover
    {
        protected Approver NextApprover;

        public void SetNext(Approver next)
        {
            NextApprover = next;
        }

        public abstract void ProcessRequest(int amount);
    }
}
