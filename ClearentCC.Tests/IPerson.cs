using System.Collections.Generic;

namespace ClearentCC.Tests
{
    public interface IPerson
    {
        double GetPersonInterest(List<IWallet> walletList);
    }
}