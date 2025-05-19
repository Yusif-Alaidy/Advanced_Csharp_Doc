namespace Assignment_02_event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount yusif = new BankAccount();
            yusif.amountIsLow += ()=>Console.WriteLine("your money is under the 30 pound...");

            yusif.Deposit(100);
            yusif.withdraw(80);
            yusif.myCash();
        }
    }
}
