namespace OpenSourceProjects
{
    public interface ITransaction
    {
        
        void CheckBalance(decimal accountBalance);
        void MakeDeposit(decimal accountBalance);
        void WithDraw(decimal accountBalance);
    }
 }
