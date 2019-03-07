using System.Transactions;

namespace ClearentCC.Tests
{
    public class CreditCard:ICreditCard
    {
        public double Amount { get; }
        public double InterestRate { get; }
        public double SimpleInterest { get; }

        public CreditCard(double amount, double interestRate)
        {
            InterestRate = interestRate;
            Amount = amount;
            SimpleInterest = GetInterest(Amount,InterestRate);
        }

        public double GetInterest(double amount, double interestRate)
        {
            return amount * interestRate;
        }

        
    }
}