using Banking.Domain;

namespace Banking.Tests.Account;
public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        var account = new BankAccount();

        decimal balance = account.GetBalance();

        Assert.Equal(5000M, balance);
    }
}