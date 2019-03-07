using System.Collections.Generic;

namespace ClearentCC.Tests
{
    public interface IWallet
    {
        double GetWalletInterest(List<ICreditCard> creditCards);
    }
}