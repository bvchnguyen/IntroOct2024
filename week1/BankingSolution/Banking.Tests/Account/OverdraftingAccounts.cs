using Banking.Domain;

namespace Banking.Tests.Account;
public class OverdraftingAccounts : BankAccount
{
    [Fact]
    public void OverdraftIsNotAllowed()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        Assert.Throws<AccountOverdraftException>(
            () => account.Withdraw(account.GetBalance() + .01M)
        );
    }
}
